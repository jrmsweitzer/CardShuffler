using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class RedEyesBDragon : NormalMonster
    {
        public RedEyesBDragon(YugiohGame game) : base(game)
        {
            Name = "Red-Eyes B. Dragon";
            Attribute = MonsterAttribute.Dark;
            Level = 7;
            Type = MonsterType.Dragon;
            ATK = 2400;
            DEF = 2000;
            SetCodes.Add("SS02-ENB01");
            CardCode = 74677422;
        }
    }
}
