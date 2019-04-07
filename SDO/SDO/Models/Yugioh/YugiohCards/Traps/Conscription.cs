using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Conscription : NormalTrap
    {
        public Conscription(YugiohGame game) : base(game)
        {
            Name = "Conscription";
            SetCodes.Add("SBLS-EN024");
            CardCode = 31000575;
            Description = "Excavate the top card of your opponent's Deck, and if it is a monster that can be Normal Summoned/Set, Special Summon it to your field. Otherwise, add that card to your opponent's hand.";
        }
    }
}
