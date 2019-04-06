using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCards.Skills
{
    public class DragonCaller: Skill
    {
        private bool HasAlreadyActivated { get; set; } = false;
        public DragonCaller(YugiohGame game) : base(game)
        {
            Name = "Dragon Caller";
            SkillActivationDescription = "Flip this card over when you activate\nthis Skill.";
            ActiveSideText = "Once per Duel, you can use 1 of the following Skills.\n* If you successfully Normal Summon \"Lord of D.\", add 1 \"The Flute\nof Summoning Dragon\" from your Deck or GY to your hand.\n* Reveal 1 \"The Flute of Summoning Dragon\" from your hand, then\nadd 1 \"Lord of D.\" from your Deck or GY to your hand.";
            SkillCount = 2;
            Character = "Kaiba";
            SetCodes.Add("SS02-ENAS3");
        }

        public new bool CanActivateFirstSkill()
        {
            if (HasAlreadyActivated) return false;
            return
                TurnPlayer.LastSuccessfulNormalSummon != null &&
                 TurnPlayer.LastSuccessfulNormalSummon.Name == "Lord of D.";
        }

        public new List<Spell> GetLegalTargetsForFirstSkill()
        {
            var list = new List<Spell>();
            var name = "The Flute of Summoning Dragon";
            list.AddRange(TurnPlayer.DiscardPile.Where(c => c.Name == name).Select(c => (Spell)c).ToList());
            list.AddRange(TurnPlayer.Deck.Cards.Where(c => c.Name == name).Select(c => (Spell)c).ToList());
            return list;
        }

        public new List<Monster> GetLegalTargetsForSecondSkill()
        {
            var list = new List<Monster>();
            var name = "Lord of D.";
            list.AddRange(TurnPlayer.DiscardPile.Where(c => c.Name == name).Select(c => (Monster)c).ToList());
            list.AddRange(TurnPlayer.Deck.Cards.Where(c => c.Name == name).Select(c => (Monster)c).ToList());
            return list;
        }

        public new bool ExecuteFirstSkill(params Card[] targets)
        {
            if (!CanActivateFirstSkill()) return false;
            if (targets == null || targets.Count() != 1) return false;
            var target = targets[0];
            if (target.Name != "The Flute of Summoning Dragon") return false;
            if (target.Location == CardLocation.Deck)
            {
                TurnPlayer.Deck.AddCardToHand(TurnPlayer.Hand, target);
                HasAlreadyActivated = true;
                return true;
            }
            if (target.Location == CardLocation.Graveyard)
            {
                TurnPlayer.DiscardPile.Remove(target);
                TurnPlayer.Hand.Add(target);
                target.Location = CardLocation.Hand;
                HasAlreadyActivated = true;
                return true;
            }
            return false;
        }

        public new bool CanActivateSecondSkill()
        {
            if (HasAlreadyActivated) return false;
            return TurnPlayer.Hand.Cards.Any(c => c is Spell spell && spell.Name == "The Flute of Summoning Dragon");
        }

        public new bool ExecuteSecondSkill(params Card[] targets)
        {
            if (targets == null || targets.Count() != 1) return false;
            var target = targets[0];
            if (target.Name != "Lord of D.") return false;
            if (target.Location == CardLocation.Deck)
            {
                TurnPlayer.Deck.AddCardToHand(TurnPlayer.Hand, target);
                HasAlreadyActivated = true;
                return true;
            }
            if (target.Location == CardLocation.Graveyard)
            {
                TurnPlayer.DiscardPile.Remove(target);
                TurnPlayer.Hand.Add(target);
                target.Location = CardLocation.Hand;
                HasAlreadyActivated = true;
                return true;
            }
            return false;
        }
    }
}
