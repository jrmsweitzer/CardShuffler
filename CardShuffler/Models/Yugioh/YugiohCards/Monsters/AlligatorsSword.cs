using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class AlligatorsSword : NormalMonster
    {
        public AlligatorsSword(YugiohGame game) : base(game)
        {
            Name = "Alligator's Sword";
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Beast;
            ATK = 1500;
            DEF = 1200;
            SetCodes.Add("SS02-ENB05");
            CardCode = 64428736;
        }
    }
}
