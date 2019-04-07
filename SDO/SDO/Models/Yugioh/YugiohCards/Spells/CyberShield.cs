using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class CyberShield : EquipSpell
    {
        public CyberShield(YugiohGame game) : base(game)
        {
            Name = "Cyber Shield";
            SetCodes.Add("SS02-ENC12");
            CardCode = 63224564;
            Description = "Equip only to \"Harpie Lady\" or \"Harpie Lady Sisters\". It gains 500 ATK.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
