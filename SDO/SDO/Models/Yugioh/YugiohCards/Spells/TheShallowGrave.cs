using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TheShallowGrave : NormalSpell
    {
        public TheShallowGrave(YugiohGame game) : base(game)
        {
            Name = "The Shallow Grave";
            SetCodes.Add("SBLS-EN039");
            CardCode = 43434803;
            Description = "Each player targets 1 monster in their own GY; each player Special Summons the target from their GY in face-down Defense Position.";
        }
    }
}
