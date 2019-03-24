using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh
{
    public class YugiohGameCard: Card
    {
        public YugiohGameCard(YugiohGame game)
        {
            Game = game;
        }
        protected YugiohGame Game { get; set; } = null;
        protected YugiohGamePlayer TurnPlayer => (YugiohGamePlayer)Game.TurnPlayer;
        protected YugiohGamePlayer DefendingPlayer => (YugiohGamePlayer)Game.TurnPlayer;
        protected YugiohGamePlayer Opponent => TurnPlayer == Owner ? DefendingPlayer : TurnPlayer;

        public List<string> SetCodes { get; set; } = new List<string>();
        public int CardCode { get; set; }
    }
}
