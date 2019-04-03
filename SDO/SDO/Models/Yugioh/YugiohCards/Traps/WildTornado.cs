using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCards.Traps
{
    public class WildTornado: NormalTrap
    {
        public WildTornado(YugiohGame game) : base(game)
        {
            Name = "Wild Tornado";
            SetCodes.Add("SS01-ENC17");
            SetCodes.Add("SS02-ENC18");
        }

        public override bool CanActivate()
        {
            if (TurnSet == Game.Turn) return false;
            return Opponent.Field.SpellTrapZones.Any(zone => zone.SpellTrapCard != null && zone.SpellTrapCard.Position == CardPosition.FaceUp);
        }
    }
}
