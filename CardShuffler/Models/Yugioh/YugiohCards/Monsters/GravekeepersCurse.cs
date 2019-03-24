﻿using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class GravekeepersCurse : EffectMonster
    {
        public GravekeepersCurse(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Curse";
            Attribute = MonsterAttribute.Dark;
            Level = 3;
            Type = MonsterType.Spellcaster;
            ATK = 800;
            DEF = 800;
            SetCodes.Add("SS01-ENB01");
            CardCode = 50712728;
        }
    }
}
