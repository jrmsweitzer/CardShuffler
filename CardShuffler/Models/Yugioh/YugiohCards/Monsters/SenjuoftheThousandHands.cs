using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class SenjuoftheThousandHands : EffectMonster
    {
        public SenjuoftheThousandHands(YugiohGame game) : base(game)
        {
            Name = "Senju of the Thousand Hands";
            Attribute = MonsterAttribute.Light;
            Level = 4;
            Type = MonsterType.Fairy;
            ATK = 1400;
            DEF = 1000;
            SetCodes.Add("SBLS-EN017");
            CardCode = 23401839;
        }
    }
}
