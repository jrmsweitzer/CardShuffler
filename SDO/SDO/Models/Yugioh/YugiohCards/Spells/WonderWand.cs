using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class WonderWand : EquipSpell
    {
        public WonderWand(YugiohGame game) : base(game)
        {
            Name = "Wonder Wand";
            SetCodes.Add("SS01-ENA14");
            CardCode = 67775894;
            Description = "Equip only to a Spellcaster-Type monster. It gains 500 ATK. If you control the equipped monster and this card: You can send both to the Graveyard; draw 2 cards.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
