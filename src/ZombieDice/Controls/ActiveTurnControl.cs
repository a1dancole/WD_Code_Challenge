using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZombieDice.App.Properties;
using ZombieDice.App.ViewModels;
using ZombieDice.Shared.Enums;
using ZombieDice.Shared.Extensions;

namespace ZombieDice.App.Controls
{
    public partial class ActiveTurnControl : UserControl
    {
        private int _lives = 3;
        private int _score = 0;

        private readonly DiceViewModel GreenDice = new DiceViewModel
        {
            DiceColor = DiceColor.Green,
            Color = Color.LightGreen,
            DiceFaces = new DiceFace[6]
                {DiceFace.Brain, DiceFace.Brain, DiceFace.Brain, DiceFace.Shotgun, DiceFace.Runner, DiceFace.Runner}
        };

        private readonly DiceViewModel RedDice = new DiceViewModel
        {
            DiceColor = DiceColor.Red,
            Color = Color.IndianRed,
            DiceFaces = new DiceFace[6]
                {DiceFace.Brain, DiceFace.Brain, DiceFace.Shotgun, DiceFace.Shotgun, DiceFace.Runner, DiceFace.Runner}
        };

        private readonly DiceViewModel YellowDice = new DiceViewModel
        {
            DiceColor = DiceColor.Yellow,
            Color = Color.LightYellow,
            DiceFaces = new DiceFace[6]
                {DiceFace.Brain, DiceFace.Shotgun, DiceFace.Shotgun, DiceFace.Shotgun, DiceFace.Runner, DiceFace.Runner}
        };

        private List<DiceViewModel> _cupOfDice = new List<DiceViewModel>();

        public ActiveTurnControl()
        {
            InitializeComponent();
            InitializeProperties();
            InitializeCupOfDice();
        }

        private void InitializeProperties()
        {
            this.lbl_Score.Text = $@"Score: {_score}";
            this.lbl_Lives.Text = $@"Lives: {_lives}";
        }

        private void InitializeCupOfDice()
        {
            _cupOfDice = new List<DiceViewModel>(13)
            {
                GreenDice,
                GreenDice,
                GreenDice,
                GreenDice,
                GreenDice,
                GreenDice,
                YellowDice,
                YellowDice,
                YellowDice,
                YellowDice,
                RedDice,
                RedDice,
                RedDice
            }.Shuffle();

            UpdateCup();
        }

        private void UpdateCup()
        {
            flp_CupOfDice.Controls.Clear();
            foreach (var dice in _cupOfDice)
            {
                flp_CupOfDice.Controls.Add(new Button { BackColor = dice.Color, Size = new Size(50, 50), Enabled = false, FlatStyle = FlatStyle.Flat});
            }
        }

        private void btn_Roll_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var runners = GetRunners();
            var selectedDice = _cupOfDice.Count >= (3 - runners.Count) ? _cupOfDice.OrderBy(o => rnd.Next()).Take((3 - runners.Count)).ToList() : _cupOfDice.OrderBy(o => rnd.Next()).ToList();
            selectedDice.AddRange(runners);
            
            for (var i = 0; i < selectedDice.Count; i++)
            {
                _cupOfDice.Remove(selectedDice[i]);
                var face = selectedDice[i].DiceFaces.OrderBy(o => rnd.Next()).FirstOrDefault();

                PerformRollCalculations(face);
                UpdateRolledDice(i, face, selectedDice[i].Color);
            }

            UpdateCup();
        }

        private void PerformRollCalculations(DiceFace face)
        {
            switch (face)
            {
                case DiceFace.Shotgun:
                    _lives--;
                    break;
                case DiceFace.Brain:
                    _score++;
                    break;
                case DiceFace.Runner:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(face), face, null);
            }

            this.lbl_Score.Text = $@"Score: {_score}";
            this.lbl_Lives.Text = $@"Lives: {_lives}";

            if (_lives <= 0)
                this.btn_Roll.Enabled = false;
        }

        private void UpdateRolledDice(int diceIndex, DiceFace face, Color diceColor)
        {
            switch (diceIndex)
            {
                case 0:
                    btn_Dice1.BackColor = diceColor;
                    btn_Dice1.BackgroundImage = face switch
                    {
                        DiceFace.Runner => Resources.runner,
                        DiceFace.Shotgun => Resources.shotgun,
                        DiceFace.Brain => Resources.brain
                    };
                    btn_Dice1.Tag = face;
                    break;
                case 1:
                    btn_Dice2.BackColor = diceColor;
                    btn_Dice2.BackgroundImage = face switch
                    {
                        DiceFace.Runner => Resources.runner,
                        DiceFace.Shotgun => Resources.shotgun,
                        DiceFace.Brain => Resources.brain
                    };
                    btn_Dice2.Tag = face;
                    break;
                case 2:
                    btn_Dice3.BackColor = diceColor;
                    btn_Dice3.BackgroundImage = face switch
                    {
                        DiceFace.Runner => Resources.runner,
                        DiceFace.Shotgun => Resources.shotgun,
                        DiceFace.Brain => Resources.brain
                    };
                    btn_Dice3.Tag = face;
                    break;
            }
        }

        private List<DiceViewModel> GetRunners()
        {
            var response = new List<DiceViewModel>();

            if (btn_Dice1?.Tag != null && (DiceFace)btn_Dice1?.Tag == DiceFace.Runner)
                response.Add(new DiceViewModel
                {
                    Color = btn_Dice1.BackColor,
                    DiceColor = btn_Dice1.BackColor == Color.LightGreen ? DiceColor.Green : btn_Dice1.BackColor == Color.IndianRed ? DiceColor.Red : DiceColor.Yellow,
                    DiceFaces = btn_Dice1.BackColor == Color.LightGreen ? GreenDice.DiceFaces : btn_Dice1.BackColor == Color.IndianRed ? RedDice.DiceFaces : YellowDice.DiceFaces,
                });
            if (btn_Dice2?.Tag != null && (DiceFace)btn_Dice2?.Tag == DiceFace.Runner)
                response.Add(new DiceViewModel
                {
                    Color = btn_Dice2.BackColor,
                    DiceColor = btn_Dice2.BackColor == Color.LightGreen ? DiceColor.Green : btn_Dice2.BackColor == Color.IndianRed ? DiceColor.Red : DiceColor.Yellow,
                    DiceFaces = btn_Dice2.BackColor == Color.LightGreen ? GreenDice.DiceFaces : btn_Dice2.BackColor == Color.IndianRed ? RedDice.DiceFaces : YellowDice.DiceFaces,
                });
            if (btn_Dice3?.Tag != null && (DiceFace)btn_Dice3?.Tag == DiceFace.Runner)
                response.Add(new DiceViewModel
                {
                    Color = btn_Dice3.BackColor,
                    DiceColor = btn_Dice3.BackColor == Color.LightGreen ? DiceColor.Green : btn_Dice3.BackColor == Color.IndianRed ? DiceColor.Red : DiceColor.Yellow,
                    DiceFaces = btn_Dice3.BackColor == Color.LightGreen ? GreenDice.DiceFaces : btn_Dice3.BackColor == Color.IndianRed ? RedDice.DiceFaces : YellowDice.DiceFaces,
                });

            return response;
        }
    }
}
