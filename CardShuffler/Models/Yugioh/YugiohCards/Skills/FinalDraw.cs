using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class FinalDraw : Skill
    {
        public FinalDraw(YugiohGame game) : base(game)
        {
            Name = "Final Draw";
            Character = "Yami Yugi";
            SetCodes.Add("SS01-ENAS3");
        }
    }
}
