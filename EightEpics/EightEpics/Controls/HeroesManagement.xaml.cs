using EightEpics.ViewModels;
using Xamarin.Forms;

namespace EightEpics.Controls
{
    public partial class HeroesManagement : ContentView
    {
        private StackLayout stackLayout = new StackLayout { BackgroundColor = Color.Silver };
        private bool _initialized = false;

        private GameViewModel _viewModel { get { return (GameViewModel)BindingContext; } }

        public HeroesManagement()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            if (!_initialized)
            {
                foreach (var heroViewModel in _viewModel.Heroes)
                {
                    var hero = new Hero { BindingContext = heroViewModel };
                    stackLayout.Children.Add(hero);
                }
                Content = stackLayout;
                _initialized = true;
            }

            base.OnBindingContextChanged();
        }
    }
}
