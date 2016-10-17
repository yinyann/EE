
using EightEpics.ViewModels;
using Xamarin.Forms;

namespace EightEpics.Controls
{
    public partial class DicesManagement : ContentView
    {
        private StackLayout stackLayout = new StackLayout();
        private bool _initialized = false;

        private GameViewModel _viewModel { get { return (GameViewModel)BindingContext; } }

        public DicesManagement()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            if (!_initialized)
            {
                foreach (var diceViewModel in _viewModel.Dices)
                {
                    var dice = new Dice { BindingContext = diceViewModel };
                    stackLayout.Children.Add(dice);
                }
                Content = stackLayout;
                _initialized = true;
            }

            base.OnBindingContextChanged();
        }
    }
}
