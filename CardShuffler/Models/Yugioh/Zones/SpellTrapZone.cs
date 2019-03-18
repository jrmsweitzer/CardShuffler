using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.Zones
{
    public class SpellTrapZone
    {
        public SpellTrap SpellTrapCard { get; set; } = null;
        public bool IsFaceup { get; set; }
    }
}
