﻿using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class EctoplasmicFortification : Skill
    {
        public EctoplasmicFortification(YugiohGame game) : base(game)
        {
            Name = "Ectoplasmic Fortification";
            Character = "Bonz";
            SetCodes.Add("SBLS-ENS01");
        }
    }
}
