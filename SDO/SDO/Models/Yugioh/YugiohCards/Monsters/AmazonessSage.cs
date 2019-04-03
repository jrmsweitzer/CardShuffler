using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AmazonessSage : EffectMonster
    {
        public AmazonessSage(YugiohGame game) : base(game)
        {
            Name = "Amazoness Sage";
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Warrior;
            ATK = 1400;
            DEF = 700;
            SetCodes.Add("SS02-ENC07");
            CardCode = 53162898;
        }
    }
}
