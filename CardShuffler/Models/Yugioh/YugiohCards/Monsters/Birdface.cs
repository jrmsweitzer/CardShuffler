﻿using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class Birdface : EffectMonster
    {
        public Birdface(YugiohGame game) : base(game)
        {
            Name = "Birdface";
            Attribute = MonsterAttribute.Wind;
            Type = MonsterType.WingedBeast;
            Level = 4;
            ATK = 1600;
            DEF = 1600;
            SetCodes.Add("SS02-ENC08");
            CardCode = 45547649;
        }
    }
}
