using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class RabidHorseman : NormalFusionMonster
    {
        public RabidHorseman(YugiohGame game) : base(game)
        {
            Name = "Rabid Horseman";
            FusionMaterials = new List<string>()
            {
                "Battle Ox",
                "Mystic Horseman"
            };
            SetCodes.Add("SBLS-EN011");
        }
    }
}
