using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DarkRabbit : NormalMonster
    {
        public DarkRabbit(YugiohGame game) : base(game)
        {
            Name = "Dark Rabbit";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Beast;
            ATK = 1100;
            DEF = 1500;
            CardCode = 99261403;
            SetCodes.Add("SS01-ENC04");
            Description = "He leaps up, down, and all around! Nobody can lay a hand on this funny bunny.";
        }
    }
}
