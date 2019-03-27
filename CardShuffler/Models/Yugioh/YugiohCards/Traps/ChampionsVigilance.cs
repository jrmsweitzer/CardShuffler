using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
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
