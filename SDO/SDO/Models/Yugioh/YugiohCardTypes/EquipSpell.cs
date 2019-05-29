using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class EquipSpell: Spell
    {
        public EquipSpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.Equip;
        }

        public override string ToString()
        {
            return $"{Name} - Equip Spell";
        }
    }
}
