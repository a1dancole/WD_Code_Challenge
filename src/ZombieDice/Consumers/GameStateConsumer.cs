using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using ZombieDice.App.Storage;
using ZombieDice.Shared.Dtos;

namespace ZombieDice.App.Consumers
{
    public class GameStateConsumer : IConsumer<GameDto[]>
    {
        private readonly LocalStore _localStore;
        public GameStateConsumer(LocalStore localStore)
        {
            _localStore = localStore;
        }
        public Task Consume(ConsumeContext<GameDto[]> context)
        {
            _localStore.SetAvailableGames(context.Message.Where(o => o.Players.Length <= 8).ToList());

            if (!string.IsNullOrEmpty(_localStore.GameName))
            {
                var thisGame = context?.Message?.FirstOrDefault(o =>
                    o.GameName.Equals(_localStore.GameName, StringComparison.CurrentCultureIgnoreCase));

                if(thisGame != null)
                    _localStore.UpdateGameState(thisGame);
            }

            return Task.CompletedTask;
        }
    }
}
