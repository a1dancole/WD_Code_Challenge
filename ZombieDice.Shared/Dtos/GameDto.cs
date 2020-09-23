using System;
using System.Collections.Generic;
using System.Text;

namespace ZombieDice.Shared.Dtos
{
    public class GameDto
    {
        public string GameName { get; set; }
        public PlayerDto[] Players { get; set; }
    }
}
