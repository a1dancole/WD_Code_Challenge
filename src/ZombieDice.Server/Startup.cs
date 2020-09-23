using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ZombieDice.Server.Consumers;
using ZombieDice.Server.Data;
using ZombieDice.Shared.Dtos;

namespace ZombieDice.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<ZombieDiceDbContext>(options =>
            {
                options.UseInMemoryDatabase("ZombieDice");
            });

            services.AddMassTransit(c =>
            {
                c.AddConsumer<NewGameConsumer>();

                c.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host("rabbitmq://rabbitmq");

                    cfg.ReceiveEndpoint("game-created", e =>
                    {
                        e.ConfigureConsumer<NewGameConsumer>(context);
                    });
                });
            });

            EndpointConvention.Map<GameDto[]>(new Uri("queue:game-state-updated"));
            services.AddMassTransitHostedService();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();
        }
    }
}
