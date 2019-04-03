using SDO.Models.Yugioh.Phases;
using System;

namespace SDO.Models.Yugioh
{
    public class YugiohGamePlayer: GamePlayer
    {
        public int LifePoints { get; set; }
        public YugiohField Field = new YugiohField();

        public void PlayTurn(YugiohGame game, int turnOfGame)
        {
            new YugiohTurn(this, game, turnOfGame).Execute();      
        }

        public Card DrawCard()
        {
            return Deck.DrawACardFromTop(Hand);
        }

        public void SetDeck(Deck deck)
        {
            Deck = new Deck();
            foreach (var card in deck.Cards)
            {
                ((YugiohGameCard)card).Owner = this;
                Deck.Cards.Add(card);
            }
        }
    }
}
