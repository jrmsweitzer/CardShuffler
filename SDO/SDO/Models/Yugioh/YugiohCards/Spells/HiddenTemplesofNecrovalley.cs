using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class HiddenTemplesofNecrovalley : ContinuousSpell
    {
        public HiddenTemplesofNecrovalley(YugiohGame game) : base(game)
        {
            Name = "Hidden Temples of Necrovalley";
            SetCodes.Add("SS01-ENB13");
            CardCode = 70000776;
            Description = "Activate only if both a \"Gravekeeper's\" monster and \"Necrovalley\" are on the field. Neither player can Special Summon monsters, except \"Gravekeeper's\" monsters. If either a \"Gravekeeper's\" monster or \"Necrovalley\" is not on the field, destroy this card.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
