using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory.ValueGeneration.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using ZombieDice.Server.Data.Models;

namespace ZombieDice.Server.Data
{
    public class ZombieDiceDbContext : DbContext
    {
        public ZombieDiceDbContext(DbContextOptions<ZombieDiceDbContext> options) : base(options) { }
        public DbSet<Game> Games { get; set; }
    }
}
