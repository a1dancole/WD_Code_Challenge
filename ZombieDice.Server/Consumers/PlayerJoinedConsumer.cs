using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using ZombieDice.Server.Data;
using ZombieDice.Server.Data.Models;
using ZombieDice.Shared.Dtos;

namespace ZombieDice.Server.Consumers
{
    public class PlayerJoinedConsumer : IConsumer<PlayerJoinedDto>
    {
        private readonly ZombieDiceDbContext _context;
        public PlayerJoinedConsumer(ZombieDiceDbContext context)
        {
            _context = context;
        }
        public async Task Consume(ConsumeContext<PlayerJoinedDto> context)
        {
            var gameToUpdate = await _context.Games.FirstOrDefaultAsync(o => o.GameName.Equals(context.Message.GameName, StringComparison.CurrentCultureIgnoreCase));
            gameToUpdate.GamePlayers.Add(new Player
            {
                PlayerName = context.Message.PlayerName,
                PlayerScore = 0,
                PlayerLives = 3,
                IsActive = false
            });
            await _context.SaveChangesAsync();
        }
    }
}
