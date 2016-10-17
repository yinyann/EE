using EightEpics.ViewModels;
using Xamarin.Forms;

namespace EightEpics.Controls
{
    public partial class Dice : ContentView
    {
        private DiceViewModel _viewModel { get { return (DiceViewModel)BindingContext; } }
        public Dice()
        {
            InitializeComponent();

            var tapGestureRecognizer = new TapGestureRecognizer
            {
                Command = new Command((o) => { DiceTapped(); })
            };
            diceValue.GestureRecognizers.Add(tapGestureRecognizer);
        }


        private void DiceTapped()
        {
            if (!_viewModel.Selected)
            {
                _viewModel.Selected = true;
                diceValue.ScaleTo(0.8, 80);
            }
            else
            {
                _viewModel.Selected = false;
                diceValue.ScaleTo(1, 80);
            }

        }
    }
}
