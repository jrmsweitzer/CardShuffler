using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class RoyalFlush : Skill
    {
        public RoyalFlush(YugiohGame game) : base(game)
        {
            Name = "Royal Flush";
            Character = "Yami Yugi";
        }
    }
}
