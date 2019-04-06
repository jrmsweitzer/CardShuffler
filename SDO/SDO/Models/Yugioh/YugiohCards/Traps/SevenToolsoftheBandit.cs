using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SevenToolsoftheBandit : CounterTrap
    {
        public SevenToolsoftheBandit(YugiohGame game) : base(game)
        {
            Name = "Sevel Tools of the Bandit";
            SetCodes.Add("SS01-ENA18");
            CardCode = 03819470;
            Description = "When a Trap Card is activated: Pay 1000 LP; negate the activation, and if you do, destroy it.";
        }
    }
}
