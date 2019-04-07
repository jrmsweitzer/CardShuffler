using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class NormalFusionMonster : FusionMonster
    {
        public NormalFusionMonster(YugiohGame game) : base(game)
        {
            Description = string.Empty;
        }
    }
}
