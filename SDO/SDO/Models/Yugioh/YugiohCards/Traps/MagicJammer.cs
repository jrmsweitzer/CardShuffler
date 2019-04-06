using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MagicJammer : CounterTrap
    {
        public MagicJammer(YugiohGame game) : base(game)
        {
            Name = "Magic Jammer";
            SetCodes.Add("SS01-ENA17");
            CardCode = 77414722;
            Description = "When a Spell Card is activated: Discard 1 card; negate the activation, and if you do, destroy it.";
        }
    }
}
