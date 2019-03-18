using System.Collections.Generic;

namespace CardShuffler.Models
{
    public class Game
    {
        public Game()
        {
        }
        public GamePlayer P1 { get; set; }
        public GamePlayer P2 { get; set; }
        public GamePlayer TurnPlayer { get; set; }
        public GamePlayer Opponent { get; set; }
        public int Turn { get; set; } = 0;
        public List<PlayerPhase> TurnOrder { get; set; }
        public bool StartingPlayerDrawsOnFirstTurn { get; set; }
        public bool OpponentDrawsOnFirstTurn { get; set; }

        public void Start(int startingHandSize)
        {
            P1.ShuffleDeck();
            P1.DrawStartingHand(startingHandSize);
            P2.ShuffleDeck();
            P2.DrawStartingHand(startingHandSize);
            Turn = 0;
        }
    }
}
