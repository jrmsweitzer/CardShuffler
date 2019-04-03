using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LusterDragon2 : NormalMonster
    {
        public LusterDragon2(YugiohGame game) : base(game)
        {
            Name = "Luster Dragon #2";
            Attribute = MonsterAttribute.Wind;
            Level = 6;
            Type = MonsterType.Dragon;
            ATK = 2400;
            DEF = 1400;
            SetCodes.Add("SS02-ENA04");
            CardCode = 17658803;
        }
    }
}
