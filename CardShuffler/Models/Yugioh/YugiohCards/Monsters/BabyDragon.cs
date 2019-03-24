using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class BabyDragon : NormalMonster
    {
        public BabyDragon(YugiohGame game) : base(game)
        {
            Name = "Baby Dragon";
            Level = 3;
            Attribute = MonsterAttribute.Wind;
            Type = MonsterType.Dragon;
            ATK = 1200;
            DEF = 700;
            SetCodes.Add("SS02-ENB06");
            CardCode = 88819587;
        }
    }
}
