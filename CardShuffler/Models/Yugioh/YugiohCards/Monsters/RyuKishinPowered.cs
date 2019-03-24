using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class RyuKishinPowered : NormalMonster
    {
        public RyuKishinPowered(YugiohGame game) : base(game)
        {
            Name = "Ryu-Kishin Powered";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Fiend;
            ATK = 1600;
            DEF = 1200;
            SetCodes.Add("SS02-ENA03");
            CardCode = 24611934;
        }
    }
}
