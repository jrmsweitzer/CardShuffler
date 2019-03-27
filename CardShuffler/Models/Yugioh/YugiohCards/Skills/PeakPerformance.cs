using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class PeakPerformance : Skill
    {
        public PeakPerformance(YugiohGame game) : base(game)
        {
            Name = "Peak Performance";
            Character = "Kaiba";
            SetCodes.Add("SS02-ENAS1");
        }
    }
}
