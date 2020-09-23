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
    public class NewGameConsumer : IConsumer<CreateGameDto>
    {
        private readonly ZombieDiceDbContext _context;
        private readonly IBus _bus;
        public NewGameConsumer(ZombieDiceDbContext context, IBus bus)
        {
            _context = context;
            _bus = bus;
        }
        public async Task Consume(ConsumeContext<CreateGameDto> consumer)
        {
            var gameId = Guid.NewGuid();
            await _context.Games.AddAsync(new Game
            {
                GameId = gameId,
                GameName = consumer.Message.GameName,
                GamePlayers = new List<Player>
                {
                    new Player
                    {
                        PlayerId = Guid.NewGuid(),
                        PlayerLives = 3,
                        PlayerScore = 0,
                        PlayerName = consumer.Message.PlayerName,
                        IsActive = false,
                        GameId = gameId
                    }
                }
            });

            await _context.SaveChangesAsync();

            await _bus.Send<GameDto[]>( _context.Games.Include(c => c.GamePlayers).Select(o => new GameDto
            {
                GameName = o.GameName,
                Players = o.GamePlayers.Select(p => new PlayerDto
                {
                    PlayerName = p.PlayerName,
                    IsActive = p.IsActive,
                    PlayerScore = p.PlayerScore,
                    PlayerLives = p.PlayerLives
                }).ToArray()
            }).ToArray());
        }
    }
}
