using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class CommonCharity : NormalTrap
    {
        public CommonCharity(YugiohGame game) : base(game)
        {
            Name = "Common Charity";
            SetCodes.Add("SBLS-EN016");
        }
    }
}
