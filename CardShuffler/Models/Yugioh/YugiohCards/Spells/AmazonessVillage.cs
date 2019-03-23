using CardShuffler.Models.Yugioh.YugiohCardTypes;
using CardShuffler.Models.Yugioh.Zones;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class AmazonessVillage : FieldSpell
    {
        YugiohFieldBuff AmazonessBoost = new YugiohNamedBuff()
        {
            NameIncludes = "Amazoness",
            ATKBuff = 200
        };

        public AmazonessVillage(YugiohGame game) : base(game)
        {
            Name = "Amazoness Village";
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
            this.Location = CardLocation.FieldSpellZone;
            this.Position = CardPosition.FaceUp;
            Game.FieldBuffs.Add(AmazonessBoost);
            return true;
        }

        public override void WhenRemoved()
        {
            Game.FieldBuffs.Remove(AmazonessBoost);
        }
    }
}
