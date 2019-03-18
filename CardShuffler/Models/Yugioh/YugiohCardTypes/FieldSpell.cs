using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public abstract class FieldSpell: Spell
    {

        public FieldSpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.Field;
        }

        public abstract void WhenRemoved();
    }
}
