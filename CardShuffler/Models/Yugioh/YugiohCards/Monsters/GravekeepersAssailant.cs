using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class GravekeepersAssailant : EffectMonster
    {
        public GravekeepersAssailant(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Assailant";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1500;
            DEF = 1500;
            SetCodes.Add("SS01-ENB06");
            CardCode = 25262697;
        }
    }
}
