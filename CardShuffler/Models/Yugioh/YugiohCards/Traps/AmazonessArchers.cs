using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class AmazonessArchers : NormalTrap
    {
        public AmazonessArchers(YugiohGame game) : base(game)
        {
            Name = "Amazoness Archers";
            SetCodes.Add("SS02-ENC15");
        }
    }
}
