﻿using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class PalOMinezation : Skill
    {
        public PalOMinezation(YugiohGame game) : base(game)
        {
            Name = "Pal-O'Mine-zation";
            Character = "Joey";
            SetCodes.Add("SS02-ENBS3");
        }
    }
}
