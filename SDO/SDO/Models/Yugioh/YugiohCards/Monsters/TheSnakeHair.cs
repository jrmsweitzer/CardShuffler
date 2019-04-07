using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TheSnakeHair : NormalMonster
    {
        public TheSnakeHair(YugiohGame game) : base(game)
        {
            Name = "The Snake Hair";
            SetCodes.Add("SBLS-EN026");
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Zombie;
            ATK = 1500;
            DEF = 1200;
            CardCode = 29491031;
            Description = "A monster with a head of poison snakes. One look from this monster can turn an opponent to stone.";
        }
    }
}
