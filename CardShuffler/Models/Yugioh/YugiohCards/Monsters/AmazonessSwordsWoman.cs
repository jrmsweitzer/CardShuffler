using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class AmazonessSwordsWoman : EffectMonster
    {
        public AmazonessSwordsWoman(YugiohGame game) : base(game)
        {
            Name = "Amazoness Swords Woman";
            ATK = 1500;
            DEF = 1600;
        }
    }
}
