using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class Kaibaman : EffectMonster
    {
        public Kaibaman(YugiohGame game) : base(game)
        {
            Name = "Kaibaman";
            Attribute = MonsterAttribute.Light;
            Level = 3;
            Type = MonsterType.Warrior;
            ATK = 200;
            DEF = 700;
            SetCodes.Add("SS02-ENA09");
            CardCode = 34627841;
        }
    }
}
