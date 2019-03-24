using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class BlackIllusionRitual : RitualSpell
    {
        public BlackIllusionRitual(YugiohGame game) : base(game)
        {
            Name = "Black Illusion Ritual";
            SetCodes.Add("SS01-ENC09");
            CardCode = 41426869;
        }

        public override bool Activate(params object[] targets)
        {
            throw new NotImplementedException();
        }

        public override bool CanActivate()
        {
            throw new NotImplementedException();
        }

        public override List<Card> GetLegalTargets()
        {
            throw new NotImplementedException();
        }

        public override bool NeedsTarget()
        {
            throw new NotImplementedException();
        }

        public override bool Resolve(params object[] targets)
        {
            throw new NotImplementedException();
        }
    }
}
