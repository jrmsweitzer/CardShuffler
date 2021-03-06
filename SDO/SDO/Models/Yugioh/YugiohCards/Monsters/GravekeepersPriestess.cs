﻿using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersPriestess : EffectMonster
    {
        public GravekeepersPriestess(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Priestess";
            Attribute = MonsterAttribute.Dark;
            Level = 3;
            Type = MonsterType.Spellcaster;
            ATK = 1000;
            DEF = 1500;
            SetCodes.Add("SS01-ENB07");
            SetCodes.Add("STP1-EN017");
            CardCode = 03381441;
            Description = "While there is no face-up Field Spell Card, the field is treated as \"Necrovalley\". All \"Gravekeeper's\" monsters gain 200 ATK and DEF.";
        }
    }
}
