using EightEpics.Models.Powers;
using Xamarin.Forms;

namespace EightEpics.Models.Heroes
{
    public interface IHero
    {
        string Name { get; }

        int LifePoints { get; }

        string Image { get; }

        Color Color { get; }

        IPower Power { get; } 
    }
}
