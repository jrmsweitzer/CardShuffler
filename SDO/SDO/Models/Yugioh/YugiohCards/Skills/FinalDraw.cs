using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
