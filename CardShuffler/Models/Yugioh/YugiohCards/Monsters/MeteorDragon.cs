using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class MeteorDragon : NormalMonster
    {
        public MeteorDragon(YugiohGame game) : base(game)
        {
            Name = "Meteor Dragon";
            Attribute = MonsterAttribute.Earth;
            Level = 6;
            Type = MonsterType.Dragon;
            ATK = 1800;
            DEF = 2000;
            SetCodes.Add("SS02-ENB02");
            CardCode = 0;
        }
    }
}
