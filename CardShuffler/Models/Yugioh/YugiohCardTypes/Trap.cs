using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public class Trap: SpellTrap
    {
        public Trap(YugiohGame game) : base(game)
        {
        }

        public TrapType TrapType { get; set; }
        public List<Effect> Effects { get; set; }
    }
}
