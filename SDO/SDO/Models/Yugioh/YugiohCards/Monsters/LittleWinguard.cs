using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LittleWinguard : EffectMonster
    {
        public LittleWinguard(YugiohGame game) : base(game)
        {
            Name = "Little Winguard";
            Attribute = MonsterAttribute.Wind;
            Level = 4;
            Type = MonsterType.Warrior;
            ATK = 1400;
            DEF = 1800;
            SetCodes.Add("SS02-ENB08");
            CardCode = 90790253;
            Description = "Once per turn, during your End Phase: You can change the battle position of this card.";
        }
    }
}
