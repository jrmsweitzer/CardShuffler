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
            SetCodes.Add("SBLS-EN012");
        }
    }
}
