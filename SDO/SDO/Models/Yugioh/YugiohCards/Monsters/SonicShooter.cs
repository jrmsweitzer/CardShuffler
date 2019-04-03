using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SonicShooter : EffectMonster
    {
        public SonicShooter(YugiohGame game) : base(game)
        {
            Name = "Sonic Shooter";
            Attribute = MonsterAttribute.Wind;
            Level = 4;
            Type = MonsterType.WingedBeast;
            ATK = 1300;
            DEF = 600;
            SetCodes.Add("SS02-ENC09");
            CardCode = 40384720;
        }
    }
}
