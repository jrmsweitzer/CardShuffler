using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class BlueEyesWhiteDragon : NormalMonster
    {
        public BlueEyesWhiteDragon(YugiohGame game) : base(game)
        {
            Name = "Blue-Eyes White Dragon";
            Attribute = MonsterAttribute.Light;
            Level = 8;
            Type = MonsterType.Dragon;
            ATK = 3000;
            DEF = 2500;
            SetCodes.Add("SS02-ENA01");
            CardCode = 89631139;
        }
    }
}
