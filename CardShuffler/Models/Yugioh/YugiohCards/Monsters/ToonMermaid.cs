using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ToonMermaid : EffectMonster
    {
        public ToonMermaid(YugiohGame game) : base(game)
        {
            Name = "Toon Mermaid";
        }
    }
}
