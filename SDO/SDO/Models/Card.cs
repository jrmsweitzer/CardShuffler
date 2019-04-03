using SDO.Models.Yugioh;

namespace SDO.Models
{
    public class Card
    {
        public string Name { get; set; }
        public CardLocation Location { get; set; } = CardLocation.Deck;
        public CardPosition Position { get; set; } = CardPosition.FaceDown;
        public GamePlayer Owner { get; set; }
    }
}
