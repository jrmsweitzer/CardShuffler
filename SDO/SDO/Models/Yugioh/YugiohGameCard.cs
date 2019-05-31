using System.Collections.Generic;
using System.Linq;

namespace SDO.Models.Yugioh
{
    public class YugiohGameCard: Card
    {
        public YugiohGameCard(YugiohGame game)
        {
            Game = game;
        }
        protected YugiohGame Game { get; set; } = null;
        protected YugiohGamePlayer TurnPlayer => (YugiohGamePlayer)Game?.TurnPlayer ?? null;
        protected YugiohGamePlayer DefendingPlayer => (YugiohGamePlayer)Game?.TurnPlayer ?? null;
        protected YugiohGamePlayer Opponent => TurnPlayer == Owner ? DefendingPlayer : TurnPlayer;
        protected List<Effect> Effects { get; set; } = new List<Effect>();

        public string Description { get; set; } = "Description not yet set";
        public List<string> SetCodes { get; set; } = new List<string>();
        public int CardCode { get; set; }
        public string Image => SetCodes.Last().Replace("-", "").ToLower() + ".png";
    }
}
