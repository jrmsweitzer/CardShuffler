using CardShuffler.Models.Yugioh;
using System;

namespace CardShuffler.Models
{
    public class Card
    {
        public string Name { get; set; }
        public CardLocation Location { get; set; } = CardLocation.Deck;
        public CardPosition Position { get; set; } = CardPosition.FaceDown;
        public bool IsRevealed { get; set; } = false;
        public GamePlayer Owner { get; set; }
    }
}
