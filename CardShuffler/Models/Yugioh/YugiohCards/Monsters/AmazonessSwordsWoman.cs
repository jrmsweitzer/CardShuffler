using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class AmazonessSwordsWoman : EffectMonster
    {
        public AmazonessSwordsWoman(YugiohGame game) : base(game)
        {
            Name = "Amazoness Swords Woman";
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Warrior;
            ATK = 1500;
            DEF = 1600;
            SetCodes.Add("SS02-ENC06");
            CardCode = 94004268;
        }
    }
}
