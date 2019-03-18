using CardShuffler.Models;
using CardShuffler.Models.Yugioh;
using NUnit.Framework;

namespace Tests
{
    public class SampleDuels: TestBase
    {
        public void SetupDuel(YugiohGamePlayer turnPlayer, Deck tpDeck, YugiohGamePlayer opponent, Deck oppDeck)
        {
            Game.P1 = turnPlayer;
            Game.P1.Deck = tpDeck;
            Game.P2 = opponent;
            Game.P2.Deck = oppDeck;
            Game.TurnPlayer = turnPlayer;
        }

        [Test]
        public void KaibaVsMai()
        {
            SetupDuel(Kaiba, BlueEyesDeck, Mai, HarpieDeck);

        }
    }
}
