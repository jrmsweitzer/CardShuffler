using CardShuffler.Models.Yugioh.YugiohCardTypes;
using CardShuffler.Models.Yugioh.Zones;
using System;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class HarpiesHuntingGround : FieldSpell
    {
        YugiohFieldBuff WingedBeastBoost = new YugiohFieldTypeBuff()
        {
            AffectedType = MonsterType.WingedBeast,
            ATKBuff = 200
        };

        public HarpiesHuntingGround(YugiohGame game) : base(game)
        {
            Name = "Harpie's Hunting Ground";
        }        

        public override bool Activate(params object[] targets)
        {
            if (TurnPlayer.Field.FieldZone.FieldSpell != null)
            {
                var oldFieldSpell = TurnPlayer.Field.FieldZone.FieldSpell;
                oldFieldSpell.WhenRemoved();
                TurnPlayer.DiscardPile.Add(oldFieldSpell);
            }
            TurnPlayer.Hand.Cards.Remove(this);
            return true;
        }
        public override bool CanActivate() => true;
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => false;
        public override bool Resolve(params object[] targets)
        {
            TurnPlayer.Field.FieldZone = new FieldZone()
            {
                FieldSpell = this,
                IsFaceup = true
            };
            this.Location = CardLocation.FieldSpellZoneFaceUp;
            Game.FieldBuffs.Add(WingedBeastBoost);
            return true;
        }
        public override void WhenRemoved()
        {
            Game.FieldBuffs.Remove(WingedBeastBoost);
        }
    }
}
