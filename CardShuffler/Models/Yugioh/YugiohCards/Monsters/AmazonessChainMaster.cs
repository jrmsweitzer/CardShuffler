using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class AmazonessChainMaster : EffectMonster
    {
        public AmazonessChainMaster(YugiohGame game) : base(game)
        {
            Name = "Amazoness Chain Master";
            ATK = 1500;
        }
    }
}
