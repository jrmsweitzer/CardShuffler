using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MindScan : Skill
    {
        public MindScan(YugiohGame game) : base(game)
        {
            Name = "Mind Scan";
            Character = "Pegasus";
            SetCodes.Add("SS01-ENCS2");
            Description = "At the start of the 3rd turn, if your LP is 3000 or higher, activate this Skill (count both players' turns).\n" +
"You may look at your opponent's Set Spell & Trap Cards at anytime. If your LP drops below 3000, flip this card over.";
        }
    }
}
