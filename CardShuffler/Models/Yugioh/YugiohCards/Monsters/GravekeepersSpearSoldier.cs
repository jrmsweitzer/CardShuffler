using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class GravekeepersSpearSoldier : EffectMonster
    {
        public GravekeepersSpearSoldier(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Spear Soldier";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1500;
            DEF = 1000;
            SetCodes.Add("SS01-ENB02");
            CardCode = 63695531;
        }
    }
}
