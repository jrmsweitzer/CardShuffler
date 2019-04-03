using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
