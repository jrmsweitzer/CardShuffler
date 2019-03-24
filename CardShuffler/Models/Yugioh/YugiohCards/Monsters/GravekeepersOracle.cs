using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class GravekeepersOracle : EffectMonster
    {
        public GravekeepersOracle(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Oracle";
            Attribute = MonsterAttribute.Dark;
            Level = 10;
            Type = MonsterType.Spellcaster;
            ATK = 2000;
            DEF = 1500;
            SetCodes.Add("SS01-ENB10");
            CardCode = 25524823;
        }
    }
}
