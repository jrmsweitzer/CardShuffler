using SDO.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BlueEyesUltimateDragon : NormalFusionMonster
    {
        public BlueEyesUltimateDragon(YugiohGame game) : base(game)
        {
            Name = "Blue-Eyes Ultimate Dragon";
            FusionMaterials = new List<string>()
            {
                "Blue-Eyes White Dragon",
                "Blue-Eyes White Dragon",
                "Blue-Eyes White Dragon",
            };
            CardCode = 23995346;
            Attribute = MonsterAttribute.Light;
            Level = 12;
            Type = MonsterType.Dragon;
            ATK = 4500;
            DEF = 3800;
            SetCodes.Add("SBLS-EN012");
        }
    }
}
