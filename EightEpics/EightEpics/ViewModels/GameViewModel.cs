using System;
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

            AddHero("Noble saint", 5, "Restore 1 LP of another hero. Reroll up to 2 dices");
            AddHero("Invincible general", 6, "ready one hero. Reroll up to 2 dices.");
            AddHero("High Paladin", 6, "change one die to result 1.");
            AddHero("Treason demon", 6, "change 1 die to a 6.");
            AddHero("Mysterious Swordmaster", 6, "Add or remove 1 die from the rolling poll.");
            AddHero("Immortal Witch", 4, "Use the power of another hero.");
            AddHero("Omniscient Magus", 5, "Choose a dice value - increase or decrease all dices showing that value");
            AddHero("Miracle artificer", 5, "Choose up to 2 dice to flip so they show their face down side");
        }

        private void AddHero(string heroName, int lifePoints, string power)
        {
            var hero = new HeroViewModel { Name = heroName, LifePoints = lifePoints, Power = power };
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
