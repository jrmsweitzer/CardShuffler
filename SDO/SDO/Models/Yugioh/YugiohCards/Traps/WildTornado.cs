using SDO.Models.Yugioh.YugiohCardTypes;
using System.Linq;

namespace SDO.Models.Yugioh.YugiohCards.Traps
{
    public class WildTornado: NormalTrap
    {
        public WildTornado(YugiohGame game) : base(game)
        {
            Name = "Wild Tornado";
            SetCodes.Add("SS01-ENC17");
            SetCodes.Add("SS02-ENC18");
            CardCode = 47766694;
            Description = "Select 1 face-up card in the Spell & Trap Card Zones and destroy it. The controller of the destroyed card can then Set 1 Spell or Trap Card from their hand. If this Set card is destroyed and sent to the Graveyard, select and destroy 1 face-up card on the field.";
        }

        public override bool CanActivate()
        {
            if (TurnSet == Game.Turn) return false;
            return Opponent.Field.SpellTrapZones.Any(zone => zone.SpellTrapCard != null && zone.SpellTrapCard.Position == CardPosition.FaceUp);
        }
    }
}
