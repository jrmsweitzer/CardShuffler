using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class Prescience : Skill
    {
        public Prescience(YugiohGame game) : base(game)
        {
            Name = "Prescience";
            Character = "Ishizu";
            SetCodes.Add("SS01-ENBS1");
        }
    }
}
