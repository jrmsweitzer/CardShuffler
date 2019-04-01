using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ArcanaKnightJoker : EffectFusionMonster
    {
        public ArcanaKnightJoker(YugiohGame game) : base(game)
        {
            Name = "Arcana Knight Joker";
            FusionMaterials = new List<string>()
            {
                "King's Knight",
                "Queen's Knight",
                "Jack's Knight"
            };
            CanUseFusionSubstitutes = false;
            SetCodes.Add("SBLS-EN007");
        }
    }
}
