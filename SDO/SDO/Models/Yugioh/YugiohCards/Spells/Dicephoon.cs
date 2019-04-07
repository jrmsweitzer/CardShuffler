using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Dicephoon : QuickplaySpell
    {
        public Dicephoon(YugiohGame game) : base(game)
        {
            Name = "Dicephoon";
            SetCodes.Add("SS02-ENB15");
            CardCode = 03493058;
            Description = "Roll a six-sided die and apply the result.\n" +
"● 2, 3, or 4: Destroy 1 Spell / Trap on the field.\n" +
"● 5: Destroy 2 Spells / Traps on the field.\n" +
"● 1 or 6: You take 1000 damage.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
