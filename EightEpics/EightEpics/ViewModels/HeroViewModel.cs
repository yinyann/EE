using EightEpics.Models.Heroes;
using System.ComponentModel;
using Xamarin.Forms;

namespace EightEpics.ViewModels
{
    public class HeroViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        bool exhausted;
        int lifePoints;

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

        public Color Color { get; set; }

        public string Image { get; set; }

        public HeroViewModel(IHero heroModel)
        {
            Name = heroModel.Name;
            lifePoints = heroModel.LifePoints;
            exhausted = false;
            Color = heroModel.Color;
            Image = heroModel.Image;
        }

        private HeroViewModel()
        {

        }
    }
}
