using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
            SetCodes.Add("SS02-ENA06");
            CardCode = 43586926;
        }


    }
}
