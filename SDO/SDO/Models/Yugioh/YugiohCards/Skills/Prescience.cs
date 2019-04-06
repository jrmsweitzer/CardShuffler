using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Prescience : Skill
    {
        public Prescience(YugiohGame game) : base(game)
        {
            Name = "Prescience";
            Character = "Ishizu";
            SetCodes.Add("SS01-ENBS1");
            Description = "If your opponent's LP is more than twice your LP, activate this Skill.\n" +
"You may look at the top card of both your and your opponent's Deck at any time.";
        }
    }
}
