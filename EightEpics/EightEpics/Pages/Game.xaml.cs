using System;
using System.Linq;
using EightEpics.Controls;
using EightEpics.ViewModels;
using Xamarin.Forms;

namespace EightEpics.Pages
{
    public partial class Game : ContentPage
    {
        private GameViewModel _viewModel = new GameViewModel();

        public Game()
        {
            InitializeComponent();
            BindingContext = _viewModel;

            var stackLayout = new StackLayout { Orientation = StackOrientation.Horizontal };

            var leftStack = new StackLayout();
            leftStack.Children.Add(new HeroesManagement { BindingContext = _viewModel });

            var rollButton = new Button { Text = "Roll" };
            rollButton.Clicked += Roll;
            leftStack.Children.Add(rollButton);

            stackLayout.Children.Add(leftStack);

            stackLayout.Children.Add(new DicesManagement { BindingContext = _viewModel });

            Content = stackLayout;
        }

        private void Roll(object sender, EventArgs e)
        {
            foreach(var diceViewModel in _viewModel.Dices.Where(_ => _.Selected))
            {
                diceViewModel.Roll();
            }
        }
    }
}
