using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCards.Spells
{
    public class ToonTableofContents: NormalSpell
    {
        public ToonTableofContents(YugiohGame game) : base(game)
        {
            Name = "Toon Table of Contents";
            SetCodes.Add("SS01-ENC10");
        }

        public override List<Card> GetLegalTargets()
        {
            return Game.TurnPlayer.Deck.Cards.Where(c => c.Name.Contains("Toon")).ToList();
        }

        public override bool CanActivate() =>
            GetLegalTargets().Count >= 1 &&
            TurnPlayer.Field.HasFreeSpellTrapZone();
        public override bool Activate(params object[] targets)
        {
            if (targets.Count() == 0) return false;
            if (targets.Count() > 1) return false;

            if (targets[0] is string cardName)
            {
                var success = CanActivate() && GetLegalTargets().Any(lt => lt.Name == cardName);
                if (!success) return false;
            }
            else if (targets[0] is YugiohGameCard card)
            {
                var success = CanActivate() && GetLegalTargets().Contains(card);
                if (!success) return false;
            }

            TurnPlayer.Hand.Cards.Remove(this);
            TurnPlayer.Field.PlaceSpellTrapFaceup(this);

            return true;
        }
        public override bool Resolve(params object[] targets)
        {
            if (targets.Count() == 0) return false;
            if (targets.Count() > 1) return false;
            if (targets[0] is Card card)
            {
                if (GetLegalTargets().Contains(card))
                {
                    var cardName = card.Name;
                    TurnPlayer.Deck.AddCardToHand(Game.TurnPlayer.Hand, cardName);
                    TurnPlayer.Field.RemoveSpellTrap(this);
                    TurnPlayer.DiscardPile.Add(this);
                    return true;
                }
                return false;
            }
            else if (targets[0] is string cardName)
            {
                if (GetLegalTargets().Any(c => c.Name == cardName))
                {
                    TurnPlayer.Deck.AddCardToHand(Game.TurnPlayer.Hand, cardName);
                    TurnPlayer.Field.RemoveSpellTrap(this);
                    TurnPlayer.DiscardPile.Add(this);
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        public override bool NeedsTarget() => true;
    }
}
