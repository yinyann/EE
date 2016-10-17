using EightEpics.Models;
using System.ComponentModel;

namespace EightEpics.ViewModels
{
    public class DiceViewModel : INotifyPropertyChanged
    {
        private Dice dice;
        public event PropertyChangedEventHandler PropertyChanged;

        public int DiceValue { get; private set; }
        bool selected;

        public bool Selected
        {
            get
            {
                return selected;
            }

            set
            {
                if(selected!=value)
                {
                selected = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Selected"));
                }
            }
        }

        public DiceViewModel()
        {
            dice = new Dice();
            DiceValue = dice.Result;
        }

        public void Roll()
        {
            DiceValue = dice.Roll();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DiceValue"));
        }
    }
}
