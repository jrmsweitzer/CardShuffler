using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class RitualSpell: Spell
    {
        public RitualSpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.Ritual;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
