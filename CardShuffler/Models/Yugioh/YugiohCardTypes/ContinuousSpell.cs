using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public abstract class ContinuousSpell: Spell
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
