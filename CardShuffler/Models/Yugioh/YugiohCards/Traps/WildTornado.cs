using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Linq;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class WildTornado : NormalTrap
    {
        public WildTornado(YugiohGame game) : base(game)
        {
            Name = "Wild Tornado";
        }

        public override bool CanActivate()
        {
            if (TurnSet == Game.Turn) return false;
            return Opponent.Field.SpellTrapZones.Any(zone => zone.SpellTrapCard != null && zone.SpellTrapCard.Position == CardPosition.FaceUp);
        }
    }
}
