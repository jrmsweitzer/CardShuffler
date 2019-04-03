using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public abstract class Spell: SpellTrap
    {
        public Spell(YugiohGame game) : base(game)
        {
        }

        public SpellType SpellType { get; internal set; }
        public abstract List<Card> GetLegalTargets();
        public abstract bool CanActivate();
        public abstract bool NeedsTarget();
        public abstract bool Activate(params object[] targets);
        public abstract bool Resolve(params object[] targets);
    }
}
