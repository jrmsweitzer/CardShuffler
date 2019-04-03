using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public abstract class Trap: SpellTrap
    {
        public Trap(YugiohGame game) : base(game)
        {
        }

        public TrapType TrapType { get; set; }
        public List<Effect> Effects { get; set; }
        public int TurnSet { get; set; } = -1;
        public abstract bool CanActivate();
    }
}
