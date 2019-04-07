using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AlligatorsSword : NormalMonster
    {
        public AlligatorsSword(YugiohGame game) : base(game)
        {
            Name = "Alligator's Sword";
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Beast;
            ATK = 1500;
            DEF = 1200;
            SetCodes.Add("SS02-ENB05");
            CardCode = 64428736;
            Description = "ey, dis mighty lissard man can swing his sword so fast, dat it's more dan da speed a sound!";
        }
    }
}
