using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class TheSternMystic : EffectMonster
    {
        public TheSternMystic(YugiohGame game) : base(game)
        {
            Name = "The Stern Mystic";
            Attribute = MonsterAttribute.Light;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1500;
            DEF = 1200;
            SetCodes.Add("SS01-ENA06");
            CardCode = 87557188;
            HasFlipEffect = true;
        }
    }
}
