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
            SkillActivationDescription = "Flip this card over when you activate this Skill.";
            Description = "If you lose 2000 or more LP, you can activate this Skill during your next Draw Phase.\n" +
"During your Draw Phase, you may search your Deck for any card, reveal it to your opponent, and add it to your hand instead of drawing.If you do that, flip this card over.";
        }
    }
}
