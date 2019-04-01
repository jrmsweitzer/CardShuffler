using System.Collections.Generic;
using System.Linq;
using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class TheFluteofSummoningDragon : NormalSpell
    {
        public TheFluteofSummoningDragon(YugiohGame game) : base(game)
        {
            Name = "The Flute of Summoning Dragon";
            SetCodes.Add("SS02-ENA10");
        }

        public override bool Activate(params object[] targets)
        {
            TurnPlayer.Hand.Cards.Remove(this);
            TurnPlayer.Field.PlaceSpellTrapFaceup(this);
            return true;
        }
        public override bool Resolve(params object[] targets)
        {
            var t1 = (Monster)targets[0];
            {
                TurnPlayer.Hand.Cards.Remove(t1);
                TurnPlayer.Field.SpecialSummonMonster(t1, true, true);
            }

            if (targets.Count() >= 2 && TurnPlayer.Field.HasFreeMonsterZone())
            {
                var t2 = (Monster)targets[1];
                TurnPlayer.Hand.Cards.Remove(t2);
                TurnPlayer.Field.SpecialSummonMonster(t2, true, true);
            }

            TurnPlayer.Field.RemoveSpellTrap(this);
            TurnPlayer.DiscardPile.Add(this);
            return true;
        }
        public override bool CanActivate() => 
            TurnPlayer.Field.GetMonsters().Any(m => m.Name == "Lord of D.") &&
            TurnPlayer.Field.HasFreeMonsterZone() ||
            TurnPlayer.Field.HasFreeSpellTrapZone();
        public override List<Card> GetLegalTargets() => TurnPlayer.Hand.Cards.Where(c => c is Monster m && m.Type == MonsterType.Dragon).ToList();
        public override bool NeedsTarget() => true;
    }
}
