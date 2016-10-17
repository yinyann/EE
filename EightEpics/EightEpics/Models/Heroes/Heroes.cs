using EightEpics.Models.Powers;
using Xamarin.Forms;

namespace EightEpics.Models.Heroes
{
    public class NobleSaint : IHero
    {
        public Color Color { get; } = Color.FromHex("#8C8E93");

        public string Image { get; } = "saint";

        public int LifePoints { get; } = 5;

        public string Name { get; } = "Noble Saint";

        public IPower Power { get; set; }
    }

    public class InvincibleGeneral : IHero
    {
        public Color Color { get; } = Color.FromHex("#B64453");

        public string Image { get; } = "general";

        public int LifePoints { get; } = 6;

        public string Name { get; } = "Invincible General";

        public IPower Power { get; set; }
    }

    public class HighPaladin : IHero
    {
        public Color Color { get; } = Color.FromHex("#A49651");

        public string Image { get; } = "paladin";

        public int LifePoints { get; } = 6;

        public string Name { get; } = "High Paladin";

        public IPower Power { get; set; }
    }

    public class TreasonDemon : IHero
    {
        public Color Color { get; } = Color.FromHex("#6C3595");

        public string Image { get; } = "demon";

        public int LifePoints { get; } = 6;

        public string Name { get; } = "Treason Demon";

        public IPower Power { get; set; }
    }

    public class Swordmaster : IHero
    {
        public Color Color { get; } = Color.FromHex("#25272D");

        public string Image { get; } = "swordmaster";

        public int LifePoints { get; } = 6;

        public string Name { get; } = "Swordmaster";

        public IPower Power { get; set; }
    }

    public class ImmortalWitch : IHero
    {
        public Color Color { get; } = Color.FromHex("#6072A5");

        public string Image { get; } = "witch";

        public int LifePoints { get; } = 4;

        public string Name { get; } = "Immortal Witch";

        public IPower Power { get; set; }
    }

    public class OmniscientMagnus : IHero
    {
        public Color Color { get; } = Color.FromHex("#4E47C4");

        public string Image { get; } = "magnus";

        public int LifePoints { get; } = 5;

        public string Name { get; } = "Omniscient Magnus";

        public IPower Power { get; set; }
    }

    public class MiracleArtificier : IHero
    {
        public Color Color { get; } = Color.FromHex("#4C914D");

        public string Image { get; } = "artificier";

        public int LifePoints { get; } = 5;

        public string Name { get; } = "Miracle Artificier";
        public IPower Power { get; set; }
    }
}
