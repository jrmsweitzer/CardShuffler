using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public abstract class EquipSpell: Spell
    {
        public EquipSpell(YugiohGame game) : base(game)
        {
            SpellType = SpellType.Equip;
        }
        
    }
}
