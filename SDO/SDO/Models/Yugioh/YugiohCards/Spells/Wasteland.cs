using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Wasteland : FieldSpell
    {
        public Wasteland(YugiohGame game) : base(game)
        {
            Name = "Wasteland";
            SetCodes.Add("SBLS-EN036");
            CardCode = 23424603;
            Description = "All Dinosaur, Zombie, and Rock monsters on the field gain 200 ATK/DEF.";
        }
    }
}
