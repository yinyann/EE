using EightEpics.Models.Heroes;
using System.Collections.Generic;
using System.ComponentModel;

namespace EightEpics.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        private List<DiceViewModel> _dicesList = new List<DiceViewModel>();
        private List<HeroViewModel> _heroes = new List<HeroViewModel>();

        public event PropertyChangedEventHandler PropertyChanged;

        public DiceViewModel[] Dices { get { return _dicesList.ToArray(); } }
        public HeroViewModel[] Heroes { get { return _heroes.ToArray(); } }

        public GameViewModel()
        {
            for (int i = 0; i < 8; i++)
            {
                var dice = new DiceViewModel();
                dice.PropertyChanged += DiceChanged;
                _dicesList.Add(dice);
            }

            AddHero(new HighPaladin());
            AddHero(new NobleSaint());
            AddHero(new InvincibleGeneral());
            AddHero(new TreasonDemon());
            AddHero(new Swordmaster());
            AddHero(new ImmortalWitch());
            AddHero(new OmniscientMagnus());
            AddHero(new MiracleArtificier());
        }

        private void AddHero(IHero heroModel)
        {
            var hero = new HeroViewModel (heroModel);
            hero.PropertyChanged += HeroChanged;

            _heroes.Add(hero);
        }

        private void HeroChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Heroes"));
        }

        private void DiceChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dices"));
        }
    }
}
