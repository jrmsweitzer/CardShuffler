using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class Spell : SpellTrap
    {
        public Spell(YugiohGame game) : base(game)
        {
        }

        public SpellType SpellType { get; internal set; }
        public virtual bool CanActivate { get; set; }
        public virtual bool Activate(params object[] targets)
        {
            return true;
        }
        public virtual bool Resolve(params object[] targets)
        {
            return true;
        }


        //public List<Card> GetLegalTargets();
        //public abstract bool CanActivate();
        //public abstract bool NeedsTarget();
        //public abstract bool Activate(params object[] targets);
        //public abstract bool Resolve(params object[] targets);
    }
}
