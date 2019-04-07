using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
            Description = "Your opponent takes any battle damage you would have taken from battles involving this card instead.";
        }
    }
}
