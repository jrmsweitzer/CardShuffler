using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class BattleOx : NormalMonster
    {
        public BattleOx(YugiohGame game) : base(game)
        {
            Name = "Battle Ox";
            ATK = 1700;
            DEF = 1000;
            Level = 4;
        }
    }
}
