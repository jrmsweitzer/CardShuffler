using SDO.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class RabidHorseman : NormalFusionMonster
    {
        public RabidHorseman(YugiohGame game) : base(game)
        {
            Name = "Rabid Horseman";
            FusionMaterials = new List<string>()
            {
                "Battle Ox",
                "Mystic Horseman"
            };
            SetCodes.Add("SBLS-EN011");
            Attribute = MonsterAttribute.Earth;
            Level = 6;
            Type = MonsterType.BeastWarrior;
            ATK = 2000;
            DEF = 1700;
            CardCode = 94905343;
        }
    }
}
