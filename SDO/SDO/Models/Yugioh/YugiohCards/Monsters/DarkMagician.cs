using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DarkMagician : NormalMonster
    {
        public DarkMagician(YugiohGame game) : base(game)
        {
            Name = "Dark Magician";
            Attribute = MonsterAttribute.Dark;
            Level = 7;
            Type = MonsterType.Spellcaster;
            ATK = 2500;
            DEF = 2100;
            SetCodes.Add("SS01-ENA01");
            SetCodes.Add("STP1-EN001");
            CardCode = 46986414;
            Description = "The ultimate wizard in terms of attack and defense.";
        }
    }
}
