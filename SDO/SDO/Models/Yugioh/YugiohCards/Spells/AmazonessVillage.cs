using SDO.Models.Yugioh.YugiohCardTypes;
using SDO.Models.Yugioh.Zones;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AmazonessVillage : FieldSpell
    {
        public AmazonessVillage(YugiohGame game) : base(game)
        {
            Name = "Amazoness Village";
            SetCodes.Add("SS02-ENV03");
            CardCode = 00712559;
            Description = "All \"Amazoness\" monsters gain 200 ATK. Once per turn, when an \"Amazoness\" monster is destroyed by battle or card effect and sent to the GY: You can Special Summon 1 \"Amazoness\" monster from your Deck with a Level less than or equal to that \"Amazoness\" monster in the GY.";
        }

        YugiohFieldBuff AmazonessBoost = new YugiohNamedBuff()
        {
            NameIncludes = "Amazoness",
            ATKBuff = 200
        };

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
