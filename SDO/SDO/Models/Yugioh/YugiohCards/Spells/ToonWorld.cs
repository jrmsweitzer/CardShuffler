using SDO.Models.Yugioh.YugiohCardTypes;
using SDO.Models.Yugioh.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCards.Spells
{
    public class ToonWorld: ContinuousSpell
    {
        public ToonWorld(YugiohGame game) : base(game)
        {
            Name = "Toon World";
            SetCodes.Add("SS01-ENC12");
            CardCode = 15259703;
            Description = "Activate this card by paying 1000 LP.";
        }

        public override bool Activate(params object[] targets)
        {
            TurnPlayer.LifePoints -= 1000;
            TurnPlayer.Hand.Cards.Remove(this);
            var freeZoneIndex = TurnPlayer.Field.SpellTrapZones.ToList().FindIndex(z => z.SpellTrapCard == null);
            TurnPlayer.Field.SpellTrapZones[freeZoneIndex] = new SpellTrapZone()
            {
                SpellTrapCard = this,
                IsFaceup = true
            };
            return true;
        }
        public override bool Resolve(params object[] targets)
        {
            return true;
        }
        public override bool CanActivate() =>
            TurnPlayer.Field.HasFreeSpellTrapZone() &&
            TurnPlayer.LifePoints > 1000;
        public override List<Card> GetLegalTargets() => throw new System.NotImplementedException();
        public override bool NeedsTarget() => false;
    }
}
