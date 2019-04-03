using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public abstract class NormalSpell: Spell
    {
        public NormalSpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.Normal;
        }        

        public override string ToString()
        {
            return $"{Name} - Normal Spell";
        }
    }
}
