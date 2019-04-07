using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DesertTwister : EffectMonster
    {
        public DesertTwister(YugiohGame game) : base(game)
        {
            Name = "Desert Twister";
            SetCodes.Add("SBLS-EN019");
            Attribute = MonsterAttribute.Wind;
            Level = 6;
            Type = MonsterType.Fiend;
            ATK = 2300;
            DEF = 2000;
            CardCode = 81977953;
            Description = "Cannot be Normal Summoned or Set. Must be Special Summoned (from your hand) by banishing 2 WIND and 1 EARTH monsters from your GY. Once per turn: You can discard 1 card, then target 1 Spell/Trap on the field; destroy it.";

            CanBeNormalSummoned = false;
        }
    }
}
