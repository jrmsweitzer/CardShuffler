using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TheEyeofTruth : ContinuousTrap
    {
        public TheEyeofTruth(YugiohGame game) : base(game)
        {
            Name = "The Eye of Truth";
            SetCodes.Add("SS01-ENB17");
        }
    }
}
