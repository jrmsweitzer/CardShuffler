using SDO.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AlligatorsSwordDragon : EffectFusionMonster
    {
        public AlligatorsSwordDragon(YugiohGame game) : base(game)
        {
            Name = "Alligator's Sword Dragon";
            SetCodes.Add("SS02-ENB22");
            Attribute = MonsterAttribute.Wind;
            Level = 5;
            Type = MonsterType.Dragon;
            Description = "This card can attack your opponent directly if the only face-up monsters they control are EARTH, WATER, or FIRE.";
            ATK = 1700;
            DEF = 1500;
            CardCode = 03366982;

            FusionMaterials = new List<string>()
            {
                "Alligator's Sword",
                "Baby Dragon"
            };
        }
    }
}
