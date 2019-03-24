using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class FeralImp : NormalMonster
    {
        public FeralImp(YugiohGame game) : base(game)
        {
            Name = "Feral Imp";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Fiend;
            ATK = 1300;
            DEF = 1400;
            CardCode = 41392891;
            SetCodes.Add("SS01-ENA02");
        }
    }
}
