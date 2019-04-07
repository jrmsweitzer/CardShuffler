using SDO.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MeteorBDragon : NormalFusionMonster
    {
        public MeteorBDragon(YugiohGame game) : base(game)
        {
            Name = "Meteor B. Dragon";
            FusionMaterials = new List<string>()
            {
                "Meteor Dragon",
                "Red-Eyes B. Dragon"
            };
            SetCodes.Add("SBLS-EN013");
            CardCode = 90660762;
            Attribute = MonsterAttribute.Fire;
            Level = 8;
            Type = MonsterType.Dragon;
            ATK = 3500;
            DEF = 2000;
        }
    }
}
