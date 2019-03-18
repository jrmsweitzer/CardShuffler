using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards.Monsters
{
    public class TwinHeadedBehemoth : EffectMonster
    {
        bool effectUsed { get; set; } = false;

        public TwinHeadedBehemoth(YugiohGame game) : base(game)
        {
            Name = "Twin-Headed Behemoth";
            ATK = 1500;
            DEF = 1200;
            Level = 3;
            Type = MonsterType.Dragon;
            Attribute = MonsterAttribute.Wind;
        }


    }
}
