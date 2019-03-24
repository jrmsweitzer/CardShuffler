using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class GravekeepersRecruiter : EffectMonster
    {
        public GravekeepersRecruiter(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Recruiter";
            Attribute = MonsterAttribute.Dark;
            Level = 3;
            Type = MonsterType.Spellcaster;
            ATK = 1200;
            DEF = 1500;
            SetCodes.Add("SS01-ENB08");
            CardCode = 93023479;
        }
    }
}
