using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class Grit : Skill
    {
        public Grit(YugiohGame game) : base(game)
        {
            Name = "Grit";
            Character = "Joey";
            SetCodes.Add("SS02-ENBS1");
        }
    }
}
