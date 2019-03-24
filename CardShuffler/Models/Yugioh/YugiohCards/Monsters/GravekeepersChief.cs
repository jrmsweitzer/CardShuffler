using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class GravekeepersChief : EffectMonster
    {
        public GravekeepersChief(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Chief";
            Attribute = MonsterAttribute.Dark;
            Level = 6;
            Type = MonsterType.Spellcaster;
            ATK = 1900;
            DEF = 1200;
            SetCodes.Add("SS01-ENB04");
            CardCode = 62473983;
        }
    }
}
