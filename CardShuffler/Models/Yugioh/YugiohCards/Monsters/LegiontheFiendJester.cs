using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class LegiontheFiendJester : EffectMonster
    {
        public LegiontheFiendJester(YugiohGame game) : base(game)
        {
            Name = "Legion the Fiend Jester";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1300;
            DEF = 1500;
            SetCodes.Add("SS01-ENA05");
            CardCode = 25280974;
        }
    }
}
