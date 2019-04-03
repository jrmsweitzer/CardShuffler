using SDO.Models;
using SDO.Models.Yugioh;
using NUnit.Framework;
using System;

namespace Tests
{
    public class SampleDuels: TestBase
    {
        [Test]
        public void GetCardWithProperCode()
        {
            var windstorm = GetCardByName("Windstorm of Etaqua");
            Assert.IsNotNull(windstorm);
        }

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
