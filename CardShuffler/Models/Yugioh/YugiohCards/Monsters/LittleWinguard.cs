using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
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
        }
    }
}
