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
            Attribute = MonsterAttribute.Fire;
            Level = 5;
            Type = MonsterType.Warrior;
            ATK = 1800;
            DEF = 1600;
            CardCode = 45231177;

            FusionMaterials = new List<string>()
            {
                "Flame Manipulator",
                "Masaki the Legendary Swordsman"
            };
        }
    }
}
