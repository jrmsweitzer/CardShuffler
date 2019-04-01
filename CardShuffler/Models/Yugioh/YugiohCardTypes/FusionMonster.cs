using CardShuffler.Models.Yugioh.YugiohCards;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public class FusionMonster: Monster
    {
        public FusionMonster(YugiohGame game) : base(game)
        {
        }

        public List<string> FusionMaterials { get; set; }
        public bool CanUseFusionSubstitutes { get; set; } = true;
    }
}
