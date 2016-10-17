using EightEpics.ViewModels;
using Xamarin.Forms;

namespace EightEpics.Controls
{
    public partial class Hero : ContentView
    {
        private HeroViewModel _viewModel { get { return (HeroViewModel)BindingContext; } }


        public Hero()
        {
            InitializeComponent();
        }
    }
}
