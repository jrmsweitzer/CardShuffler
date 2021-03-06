﻿using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class DoubleCoston : EffectMonster
    {
        public DoubleCoston(YugiohGame game) : base(game)
        {
            Name = "Double Coston";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Zombie;
            ATK = 1700;
            DEF = 1650;
            SetCodes.Add("SS01-ENA07");
            CardCode = 44436472;
        }
    }
}
