using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class LusterDragon2 : NormalMonster
    {
        public LusterDragon2(YugiohGame game) : base(game)
        {
            Name = "Luster Dragon #2";
            Level = 6;
        }
    }
}
