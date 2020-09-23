using System;
using System.Collections.Generic;
using System.Text;

namespace ZombieDice.Shared.Dtos
{
    public class CreateGameDto
    {
        public string PlayerName { get; set; }
        public string GameName { get; set; }
    }
}
