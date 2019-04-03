using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ChampionsVigilance : CounterTrap
    {
        public ChampionsVigilance(YugiohGame game) : base(game)
        {
            Name = "Champion's Vigilance";
            SetCodes.Add("SS02-ENV01");
        }
    }
}
