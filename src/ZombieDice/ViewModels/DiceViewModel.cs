using System.Drawing;
using ZombieDice.Shared.Enums;

namespace ZombieDice.App.ViewModels
{
    public class DiceViewModel
    {
        public DiceColor DiceColor { get; set; }
        public Color Color { get; set; }
        public DiceFace[] DiceFaces { get; set; }
    }
}
