using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class CalloftheHaunted : Skill
    {
        public CalloftheHaunted(YugiohGame game) : base(game)
        {
            Name = "Call of the Haunted";
            Character = "Bonz";
        }
    }
}
