using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SevenToolsoftheBandit : CounterTrap
    {
        public SevenToolsoftheBandit(YugiohGame game) : base(game)
        {
            Name = "Sevel Tools of the Bandit";
            SetCodes.Add("SS01-ENA18");
        }
    }
}
