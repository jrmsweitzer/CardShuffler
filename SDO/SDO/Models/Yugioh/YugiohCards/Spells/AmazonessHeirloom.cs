using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AmazonessHeirloom : EquipSpell
    {
        public AmazonessHeirloom(YugiohGame game) : base(game)
        {
            Name = "Amazoness Heirloom";
            SetCodes.Add("SS02-ENC14");
            CardCode = 79965360;
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
