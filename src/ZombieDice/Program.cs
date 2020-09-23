using System;
using System.Threading;
using System.Windows.Forms;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ZombieDice.App.Consumers;
using ZombieDice.App.Controls;
using ZombieDice.App.Storage;
using ZombieDice.Shared.Dtos;

namespace ZombieDice.App
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddMassTransit(c =>
                    {
                        c.AddConsumer<GameStateConsumer>();

                        c.UsingRabbitMq((context, cfg) =>
                        {
                            cfg.Host("rabbitmq://localhost:5672");
                            cfg.ReceiveEndpoint("game-state-updated",
                                e =>
                                {
                                    e.ConfigureConsumer<GameStateConsumer>(context);
                                });
                        });
                    });

                    EndpointConvention.Map<CreateGameDto>(new Uri("queue:game-created"));
                    services.AddHostedService<MassTransHostedService>();

                    services.AddSingleton<MainWindow>();

                    services.AddSingleton<LocalStore>();

                    services.AddScoped<EnterNameControl>().AddScoped(serviceProvider => new Lazy<EnterNameControl>(serviceProvider.GetRequiredService<EnterNameControl>));
                    services.AddScoped<LandingControl>().AddScoped(serviceProvider => new Lazy<LandingControl>(serviceProvider.GetRequiredService<LandingControl>));
                    services.AddScoped<CreateGameControl>().AddScoped(serviceProvider => new Lazy<CreateGameControl>(serviceProvider.GetRequiredService<CreateGameControl>));
                    services.AddScoped<ActiveTurnControl>().AddScoped(serviceProvider => new Lazy<ActiveTurnControl>(serviceProvider.GetRequiredService<ActiveTurnControl>));
                });

            var host = builder.Build();
            try
            {
                using var scope = host.Services.CreateScope();
                {
                    var services = scope.ServiceProvider;
                    var mainWindow = services.GetRequiredService<MainWindow>();
                    host.StartAsync();
                    Application.Run(mainWindow);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
