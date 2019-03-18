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
    }
}
