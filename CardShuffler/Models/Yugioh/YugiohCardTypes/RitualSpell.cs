using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public abstract class RitualSpell: Spell
    {
        public RitualSpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.Ritual;
        }
    }
}
