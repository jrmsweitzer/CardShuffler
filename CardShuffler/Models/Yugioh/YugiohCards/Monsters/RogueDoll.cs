using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class RogueDoll : NormalMonster
    {
        public RogueDoll(YugiohGame game) : base(game)
        {
            Name = "Rogue Doll";
            Attribute = MonsterAttribute.Light;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1600;
            DEF = 1000;
            SetCodes.Add("SS01-ENA03");
            SetCodes.Add("SS01-ENC01");
        }
    }
}
