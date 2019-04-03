using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ToonSummonedSkull : EffectMonster
    {
        public ToonSummonedSkull(YugiohGame game) : base(game)
        {
            Name = "Toon Summoned Skull";
            Attribute = MonsterAttribute.Dark;
            Level = 6;
            Type = MonsterType.Fiend;
            ATK = 2500;
            DEF = 1200;
            SetCodes.Add("SS01-ENC07");
            CardCode = 91842653;
        }
    }
}
