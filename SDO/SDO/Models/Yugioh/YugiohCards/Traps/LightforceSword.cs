using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LightforceSword : NormalTrap
    {
        public LightforceSword(YugiohGame game) : base(game)
        {
            Name = "Lightforce Sword";
            SetCodes.Add("SS01-ENA15");
            CardCode = 49587034;
            Description = "Banish 1 random card from your opponent's hand, face-down. During your opponent's 4th Standby Phase after this card's activation, return that card to their hand.";
        }
    }
}
