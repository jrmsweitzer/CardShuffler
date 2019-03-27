using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
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
