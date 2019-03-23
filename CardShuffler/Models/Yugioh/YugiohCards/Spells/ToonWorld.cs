using System.Collections.Generic;
using System.Linq;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using CardShuffler.Models.Yugioh.Zones;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ToonWorld : ContinuousSpell
    {
        public ToonWorld(YugiohGame game) : base(game)
        {
            Name = "Toon World";
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
