using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class LastGamble : Skill
    {
        public LastGamble(YugiohGame game) : base(game)
        {
            Name = "Last Gamble";
            Character = "Joey";
            SetCodes.Add("SS02-ENBS2");
        }
    }
}
