using SDO.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ThousandDragon : NormalFusionMonster
    {
        public ThousandDragon(YugiohGame game) : base(game)
        {
            Name = "Thousand Dragon";
            SetCodes.Add("SS02-ENB21");
            Attribute = MonsterAttribute.Wind;
            Level = 7;
            Type = MonsterType.Dragon;
            ATK = 2400;
            DEF = 2000;
            CardCode = 41462083;

            FusionMaterials = new List<string>()
            {
                "Baby Dragon",
                "Time Wizard"
            };
        }
    }
}
