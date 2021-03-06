﻿using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GearfriedtheIronKnight : EffectMonster
    {
        public GearfriedtheIronKnight(YugiohGame game) : base(game)
        {
            Name = "Gearfried the Iron Knight";
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Warrior;
            ATK = 1800;
            DEF = 1600;
            SetCodes.Add("SS02-ENB10");
            SetCodes.Add("STP1-EN009");
            CardCode = 00423705;
            Description = "If either player equips an Equip Card(s) to this card: Destroy that Equip Card(s).";
        }
    }
}
