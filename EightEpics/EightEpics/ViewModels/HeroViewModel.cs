using System.ComponentModel;

namespace EightEpics.ViewModels
{
    public class HeroViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        bool exhausted;

        public bool Exhausted
        {
            get
            {
                return exhausted;
            }

            set
            {
                if(exhausted != value)
                {
                    exhausted = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Exhausted"));
                }
            }
        }
        int lifePoints;

        public int LifePoints
        {
            get
            {
                return lifePoints;
            }

            set
            {
                if(lifePoints != value)
                {
                    lifePoints = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LifePoints"));
                }
            }
        }

        public string Name { get; set; }
        public string Power { get; set; }
    }
}
