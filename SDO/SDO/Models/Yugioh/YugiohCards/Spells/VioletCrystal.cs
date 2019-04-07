using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class VioletCrystal : EquipSpell
    {
        public VioletCrystal(YugiohGame game) : base(game)
        {
            Name = "Violet Crystal";
            SetCodes.Add("SBLS-EN035");
            CardCode = 15052462;
            Description = "(This card is not treated as a \"Crystal\" card.)\n" +
"Equip only to a Zombie monster. It gains 300 ATK / DEF.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
