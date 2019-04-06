using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SwordofDeepSeated : EquipSpell
    {
        public SwordofDeepSeated(YugiohGame game) : base(game)
        {
            Name = "Sword of Deep-Seated";
            SetCodes.Add("SS01-ENC14");
            CardCode = 98495314;
            Description = "Increase the ATK and DEF of a monster equipped with this card by 500 points. When this card is sent to the GY, place it on top of your Deck.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
