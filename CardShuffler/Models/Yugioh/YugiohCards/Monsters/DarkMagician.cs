using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
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
            CardCode = 46986414;
        }
    }
}
