using SDO.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class FlameSwordsman : NormalFusionMonster
    {
        public FlameSwordsman(YugiohGame game) : base(game)
        {
            Name = "Flame Swordsman";
            SetCodes.Add("SS02-ENB20");

            FusionMaterials = new List<string>()
            {
                "Flame Manipulator",
                "Masaki the Legendary Swordsman"
            };
        }
    }
}
