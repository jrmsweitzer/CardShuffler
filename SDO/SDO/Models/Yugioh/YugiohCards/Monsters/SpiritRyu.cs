using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SpiritRyu : EffectMonster
    {
        public SpiritRyu(YugiohGame game) : base(game)
        {
            Name = "Spirit Ryu";
            Attribute = MonsterAttribute.Wind;
            Level = 4;
            Type = MonsterType.Dragon;
            ATK = 1000;
            DEF = 1000;
            SetCodes.Add("SS02-ENA08");
            CardCode = 67957315;
        }
    }
}
