using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
            Description = "This card can be treated as 2 Tributes for the Tribute Summon of a DARK monster.";
        }
    }
}
