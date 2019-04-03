using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TyrantDragon : EffectMonster
    {
        public TyrantDragon(YugiohGame game) : base(game)
        {
            Name = "Tyrant Dragon";
            Attribute = MonsterAttribute.Fire;
            Level = 8;
            Type = MonsterType.Dragon;
            ATK = 2900;
            DEF = 2500;
            SetCodes.Add("SS02-ENA07");
            CardCode = 94568601;
        }
    }
}
