using SDO.Models.Yugioh.YugiohCardTypes;
using SDO.Models.Yugioh.Zones;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
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
            SetCodes.Add("SS02-ENC13");
            CardCode = 75782277;
            Description = "All Winged Beast monsters gain 200 ATK/DEF. If any \"Harpie Lady\" or \"Harpie Lady Sisters\" is Normal or Special Summoned: The player who conducted the Summon targets 1 Spell/Trap on the field; that player destroys that target.";
        }        

        public bool Activate(params object[] targets)
        {
            if (TurnPlayer.Field.FieldZone.FieldSpell != null)
            {
                var oldFieldSpell = TurnPlayer.Field.FieldZone.FieldSpell;
                //oldFieldSpell.WhenRemoved();
                TurnPlayer.DiscardPile.Add(oldFieldSpell);
            }
            TurnPlayer.Hand.Cards.Remove(this);
            return true;
        }
        public bool CanActivate() => true;
        
        public bool NeedsTarget() => false;
        public bool Resolve(params object[] targets)
        {
            TurnPlayer.Field.FieldZone = new FieldZone()
            {
                FieldSpell = this,
                IsFaceup = true
            };
            this.Location = CardLocation.FieldSpellZone;
            this.Position = CardPosition.FaceUp;
            Game.FieldBuffs.Add(WingedBeastBoost);
            return true;
        }
        public void WhenRemoved()
        {
            Game.FieldBuffs.Remove(WingedBeastBoost);
        }
    }
}
