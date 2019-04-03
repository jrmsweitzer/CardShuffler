using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public abstract class FieldSpell: Spell
    {

        public FieldSpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.Field;
        }

        public override string ToString()
        {
            return $"{Name} - Field Spell";
        }

        public abstract void WhenRemoved();
    }
}
