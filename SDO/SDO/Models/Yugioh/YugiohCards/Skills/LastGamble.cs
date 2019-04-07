using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LastGamble : Skill
    {
        public LastGamble(YugiohGame game) : base(game)
        {
            Name = "Last Gamble";
            Character = "Joey";
            SetCodes.Add("SS02-ENBS2");
            Description = "At the start of the 5th turn, activate this Skill (count both players' turns).\n" +
"During your Main Phase, you can reduce your LP to 100 and discard 2 cards from your hand. Roll a six - sided die and draw cards equal to the result. This Skill can only be used once per Duel.";
        }
    }
}
