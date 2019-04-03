using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.Zones
{
    public class SpellTrapZone
    {
        public SpellTrap SpellTrapCard { get; set; } = null;
        public bool IsFaceup { get; set; }
    }
}
