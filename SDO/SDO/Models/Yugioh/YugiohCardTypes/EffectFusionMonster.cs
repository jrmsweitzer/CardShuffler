using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class EffectFusionMonster: FusionMonster
    {
        public EffectFusionMonster(YugiohGame game) : base(game)
        {
        }

        public List<Effect> Effects { get; set; }
    }
}
