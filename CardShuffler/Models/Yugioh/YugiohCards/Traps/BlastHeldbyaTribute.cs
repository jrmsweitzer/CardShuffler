using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class BlastHeldbyaTribute : NormalTrap
    {
        public BlastHeldbyaTribute(YugiohGame game) : base(game)
        {
            Name = "Blast Held by a Tribute";
            SetCodes.Add("SS01-ENB15");
        }
    }
}
