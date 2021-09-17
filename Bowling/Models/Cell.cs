using GalaSoft.MvvmLight;

namespace Bowling.Models
{
    public class Cell : ViewModelBase
    {
        public bool TheLast { get; set; }
        private int? firstRoll; public int? FirstRoll { get => firstRoll; set => Set(ref firstRoll, value); }
        private int? secondRoll; public int? SecondRoll
        {
            get => secondRoll; set
            {
                Set(ref secondRoll, value);
                ResultRoll = FirstRoll + SecondRoll;
            }
        }
        private int? bonusRoll; public int? BonusRoll { get => bonusRoll; set => Set(ref bonusRoll, value); }
        private int? resultRoll; public int? ResultRoll { get => resultRoll; set => Set(ref resultRoll, value); }
    }
}