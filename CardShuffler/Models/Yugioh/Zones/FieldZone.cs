using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.Zones
{
    public class FieldZone
    {
        public FieldSpell FieldSpell { get; set; } = null;
        public bool IsFaceup { get; set; }
    }
}
