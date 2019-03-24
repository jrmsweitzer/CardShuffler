using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class BlueDragonSummoner : EffectMonster
    {
        public BlueDragonSummoner(YugiohGame game) : base(game)
        {
            Name = "Blue Dragon Summoner";
            Attribute = MonsterAttribute.Wind;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1500;
            DEF = 600;
            SetCodes.Add("SS01-ENA08");
            CardCode = 55969226;
        }
    }
}
