using System;
using System.Collections.Generic;
using System.Text;

namespace ZombieDice.Shared.Dtos
{
    public class PlayerDto
    {
        public string PlayerName { get; set; }
        public int PlayerLives { get; set; }
        public int PlayerScore { get; set; }
        public bool IsActive { get; set; }
    }
}
