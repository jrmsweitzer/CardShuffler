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
            SkillActivationDescription = "Flip this card over when you activate this Skill.";
            Description = "Activate this Skill during your Main Phase.\n" +
"Once per turn, during your turn, you may place a counter on this Skill.If it has 3 or more counters when you would draw a card, you may search your Deck for any card and add it to your hand instead.At the end of the turn you use this Skill, you lose the Duel.";
        }
    }
}
