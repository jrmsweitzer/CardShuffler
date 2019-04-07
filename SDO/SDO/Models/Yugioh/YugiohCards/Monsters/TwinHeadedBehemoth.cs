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
            Description = "During the End Phase, if this card is in the GY because it was destroyed on the field and sent there this turn: You can Special Summon this card, but its ATK/DEF become 1000. You can only use this effect of \"Twin - Headed Behemoth\" once per Duel.";
        }


    }
}
