using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.Zones
{
    public class FieldZone
    {
        public FieldSpell FieldSpell { get; set; } = null;
        public bool IsFaceup { get; set; }
    }
}
