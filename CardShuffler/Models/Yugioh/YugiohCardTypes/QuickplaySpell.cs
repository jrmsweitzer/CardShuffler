using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public abstract class QuickplaySpell: Spell
    {
        public QuickplaySpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.QuickPlay;
        }
    }
}
