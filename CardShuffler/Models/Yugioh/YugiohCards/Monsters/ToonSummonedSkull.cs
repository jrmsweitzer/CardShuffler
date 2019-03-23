using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ToonSummonedSkull : EffectMonster
    {
        public ToonSummonedSkull(YugiohGame game) : base(game)
        {
            Name = "Toon Summoned Skull";
        }
    }
}
