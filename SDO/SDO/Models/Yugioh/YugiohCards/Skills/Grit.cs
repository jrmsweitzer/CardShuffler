using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Grit : Skill
    {
        public Grit(YugiohGame game) : base(game)
        {
            Name = "Grit";
            Character = "Joey";
            SetCodes.Add("SS02-ENBS1");
            Description = "At the start of your turn, call 2 numbers and roll a six-sided die. If you roll a number you called, your LP do not get lower than 1 until the end of your opponent's next turn. This Skill can only be used once per Duel.";
        }
    }
}
