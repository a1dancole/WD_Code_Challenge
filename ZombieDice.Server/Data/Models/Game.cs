using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieDice.Server.Data.Models
{
    public class Game
    {
        [Key]
        public Guid GameId { get; set; }
        public string GameName { get; set; }
        public List<Player> GamePlayers { get; set; }
    }
}
