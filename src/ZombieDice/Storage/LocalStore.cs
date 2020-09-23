using System;
using System.Collections.Generic;
using ZombieDice.Shared.Dtos;

namespace ZombieDice.App.Storage
{
    public class LocalStore
    {
        public string PlayerName { get; private set; }
        public event EventHandler PlayerNameChanged;
        public void SetPlayerName(string playerName)
        {
            PlayerName = playerName;
            PlayerNameChanged?.Invoke(this, new NameChangedEventArgs
            {
                PlayerName = PlayerName
            });
        }

        public string GameName { get; private set; }
        public event EventHandler GameNameChanged;
        public void SetGameName(string gameName)
        {
            GameName = gameName;
            GameNameChanged?.Invoke(this, new GameNameChangedEventArgs
            {
                GameName = GameName
            });
        }

        public GameDto GameState { get; private set; }
        public event EventHandler GameStateChanged;

        public void UpdateGameState(GameDto game)
        {
            GameState = game;
            GameStateChanged?.Invoke(this, new GameStateUpdatedEventArgs
            {
                Game = GameState
            });
        }

        public List<GameDto> AvailableGames { get; private set; }
        public event EventHandler AvailableGamesChanged;

        public void SetAvailableGames(List<GameDto> games)
        {
            AvailableGames = games;
            AvailableGamesChanged?.Invoke(this, new AvailableGamesChangedEventArgs
            {
                AvailableGames = AvailableGames
            });
        }
    }

    public class NameChangedEventArgs : EventArgs
    {
        public string PlayerName { get; set; }
    }
    public class GameNameChangedEventArgs : EventArgs
    {
        public string GameName { get; set; }
    }
    public class GameStateUpdatedEventArgs : EventArgs
    {
        public GameDto Game { get; set; }
    }
    public class AvailableGamesChangedEventArgs : EventArgs
    {
        public List<GameDto> AvailableGames { get; set; }
    }
}
