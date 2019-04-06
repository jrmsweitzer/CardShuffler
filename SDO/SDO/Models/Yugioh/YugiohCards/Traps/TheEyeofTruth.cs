using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TheEyeofTruth : ContinuousTrap
    {
        public TheEyeofTruth(YugiohGame game) : base(game)
        {
            Name = "The Eye of Truth";
            SetCodes.Add("SS01-ENB17");
            CardCode = 34694160;
            Description = "Your opponent must keep their hand revealed. During each of your opponent's Standby Phases, if they have a Spell Card in their hand: They gain 1000 LP.";
        }
    }
}
