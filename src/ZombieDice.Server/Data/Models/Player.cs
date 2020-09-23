using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;

namespace ZombieDice.Server.Data.Models
{
    public class Player
    {
        [Key]
        public Guid PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerLives { get; set; }
        public int PlayerScore { get; set; }
        public bool IsActive { get; set; }
        public Guid GameId { get; set; }
        [ForeignKey("GameId")]
        public virtual Game Game { get; set; }
    }
}
