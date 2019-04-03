using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
