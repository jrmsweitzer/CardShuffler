using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Yami : FieldSpell
    {
        public Yami(YugiohGame game) : base(game)
        {
            Name = "Yami";
            SetCodes.Add("SS01-ENC13");
            CardCode = 59197169;
            Description = "Increases the ATK and DEF of all Fiend and Spellcaster-Type monsters by 200 points. Also decreases the ATK and DEF of all Fairy-Type monsters by 200 points.";
        }
    }
}
