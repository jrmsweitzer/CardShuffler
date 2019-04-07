using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DiffusionWaveMotion : NormalSpell
    {
        public DiffusionWaveMotion(YugiohGame game) : base(game)
        {
            Name = "Diffusion Wave-Motion";
            SetCodes.Add("SBLS-EN008");
            CardCode = 87880531;
            Description = "(This card is not treated as a \"Fusion\" card.)\n" +
"If your opponent controls a monster: Pay 1000 LP, then target 1 Level 7 or higher Spellcaster monster you control; this turn, it must attack all monsters your opponent controls once each, also other monsters you control cannot attack. The effects of monsters destroyed by these attacks cannot activate and are negated.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
