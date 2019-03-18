using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards.Monsters
{
    public class RedEyesBlackDragon : NormalMonster
    {
        public RedEyesBlackDragon(YugiohGame game) : base(game)
        {
            Name = "Red-Eyes B. Dragon";
            Attribute = MonsterAttribute.Dark;
            Level = 7;
            Type = MonsterType.Dragon;
            ATK = 2400;
            DEF = 2000;
        }
    }
}
