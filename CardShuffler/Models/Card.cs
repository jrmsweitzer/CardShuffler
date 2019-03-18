using CardShuffler.Models.Yugioh;
using System;

namespace CardShuffler.Models
{
    public class Card
    {
        public string Name { get; set; }
        public CardLocation Location { get; set; } = CardLocation.DeckFaceDown;
        public GamePlayer Owner { get; set; }
    }
}
