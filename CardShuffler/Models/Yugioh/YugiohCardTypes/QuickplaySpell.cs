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

        public int TurnSet { get; set; } = -1;

        public override bool CanActivate()
        {
            if (TurnSet < Game.Turn)
                return true;
            return false;
        }
    }
}
