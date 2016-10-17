using EightEpics.ViewModels;
using Xamarin.Forms;

namespace EightEpics.Controls
{
    public partial class HeroesManagement : ContentView
    {
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
                int lineNb = 0;
                int columnNb = 0;
                foreach (var heroViewModel in _viewModel.Heroes)
                {
                    var hero = new Hero { BindingContext = heroViewModel };
                    heroes.Children.Add(hero, columnNb % 3, lineNb);
                    columnNb++;
                    if (columnNb == 6)
                        lineNb = 2;
                    if (columnNb == 3)
                        lineNb = 1;
                }
                _initialized = true;
            }

            base.OnBindingContextChanged();
        }
    }
}
