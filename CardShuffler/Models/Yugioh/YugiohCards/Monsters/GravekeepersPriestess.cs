using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class GravekeepersPriestess : EffectMonster
    {
        public GravekeepersPriestess(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Priestess";
            Attribute = MonsterAttribute.Dark;
            Level = 3;
            Type = MonsterType.Spellcaster;
            ATK = 1000;
            DEF = 1500;
            SetCodes.Add("SS01-ENB07");
            CardCode = 03381441;
        }
    }
}
