using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class RiteofSpirit : NormalTrap
    {
        public RiteofSpirit(YugiohGame game) : base(game)
        {
            Name = "Rite of Spirit";
            SetCodes.Add("SS01-ENB16");
            CardCode = 30450531;
            Description = "Target 1 \"Gravekeeper's\" monster in your Graveyard; Special Summon that target. This card's activation and effect are unaffected by \"Necrovalley\".";
        }
    }
}
