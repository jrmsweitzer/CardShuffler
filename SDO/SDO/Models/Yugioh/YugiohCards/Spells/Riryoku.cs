using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Riryoku : NormalSpell
    {
        public Riryoku(YugiohGame game) : base(game)
        {
            Name = "Riryoku";
            SetCodes.Add("SS01-ENA12");
            CardCode = 34016756;
            Description = "Target 2 face-up monsters on the field; halve the ATK of 1 monster, and if you do, add that lost ATK to the other monster. These effects last until the End Phase.";
        }
    }
}
