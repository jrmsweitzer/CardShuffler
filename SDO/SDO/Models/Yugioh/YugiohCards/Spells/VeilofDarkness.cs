﻿using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    class VeilofDarkness : ContinuousSpell
    {
        public VeilofDarkness(YugiohGame game) : base(game)
        {
            Name = "Veil of Darkness";
            SetCodes.Add("SBLS-EN023");
            CardCode = 90434926;
            Description = "During your Draw Phase, if you draw a DARK monster(s): You can reveal any number of them; send them to the GY, then you can draw 1 more card.";
        }
    }
}
