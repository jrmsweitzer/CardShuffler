﻿using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ToonDefense : ContinuousTrap
    {
        public ToonDefense(YugiohGame game) : base(game)
        {
            Name = "Toon Defense";
            SetCodes.Add("SS01-ENC15");
        }
    }
}
