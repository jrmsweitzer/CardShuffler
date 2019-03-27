using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class DestinyDraw : Skill
    {
        public DestinyDraw(YugiohGame game) : base(game)
        {
            Name = "Destiny Draw";
            Character = "Yami Yugi";
            SetCodes.Add("SS01-ENAS2");
        }
    }
}
