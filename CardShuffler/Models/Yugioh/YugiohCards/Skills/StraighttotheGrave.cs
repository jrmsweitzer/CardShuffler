using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class StraighttotheGrave : Skill
    {
        public StraighttotheGrave(YugiohGame game) : base(game)
        {
            Name = "Straight to the Grave";
            Character = "Bonz";
            SetCodes.Add("SBLS-ENS02");
        }
    }
}
