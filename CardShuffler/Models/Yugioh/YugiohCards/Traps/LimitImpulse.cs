using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class LimitImpulse : NormalTrap
    {
        public LimitImpulse(YugiohGame game) : base(game)
        {
            Name = "Limit Impulse";
            SetCodes.Add("SBLS-EN045");
        }
    }
}
