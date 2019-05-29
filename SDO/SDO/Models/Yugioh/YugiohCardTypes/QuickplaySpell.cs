using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class QuickplaySpell: Spell
    {
        public QuickplaySpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.QuickPlay;
        }

        public override string ToString()
        {
            return $"{Name} - Quickplay Spell";
        }

        public int TurnSet { get; set; } = -1;

        public bool CanActivate()
        {
            if (TurnSet < Game.Turn)
                return true;
            return false;
        }
    }
}
