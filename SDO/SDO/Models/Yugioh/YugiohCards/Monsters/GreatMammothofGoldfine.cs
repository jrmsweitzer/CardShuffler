using SDO.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GreatMammothofGoldfine : NormalFusionMonster
    {
        public GreatMammothofGoldfine(YugiohGame game) : base(game)
        {
            Name = "Great Mammoth of Goldfine";
            SetCodes.Add("SBLS-EN034");
            Attribute = MonsterAttribute.Dark;
            Level = 6;
            Type = MonsterType.Zombie;
            ATK = 2200;
            DEF = 1800;
            CardCode = 54622031;

            FusionMaterials = new List<string>()
            {
                "The Snake Hair",
                "Dragon Zombie"
            };
        }
    }
}
