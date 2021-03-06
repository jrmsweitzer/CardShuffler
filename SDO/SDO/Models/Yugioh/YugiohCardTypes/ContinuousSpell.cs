﻿using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class ContinuousSpell: Spell
    {
        public ContinuousSpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.Continuous;
        }

        public override string ToString()
        {
            return $"{Name} - Continuous Spell";
        }
    }
}
