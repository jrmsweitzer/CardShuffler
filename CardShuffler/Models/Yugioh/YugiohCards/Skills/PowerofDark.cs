using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class PowerofDark : Skill
    {
        public PowerofDark(YugiohGame game) : base(game)
        {
            Name = "Power of Dark";
            Character = "Yami Yugi";
            SetCodes.Add("SS01-ENAS1");
        }
    }
}
