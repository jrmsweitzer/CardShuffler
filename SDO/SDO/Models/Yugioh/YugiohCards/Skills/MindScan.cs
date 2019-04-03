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
        }
    }
}
