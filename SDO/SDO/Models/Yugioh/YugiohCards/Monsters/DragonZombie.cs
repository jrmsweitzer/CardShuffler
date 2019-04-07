using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DragonZombie : NormalMonster
    {
        public DragonZombie(YugiohGame game) : base(game)
        {
            Name = "Dragon Zombie";
            SetCodes.Add("SBLS-EN028");
            Attribute = MonsterAttribute.Dark;
            Level = 3;
            Type = MonsterType.Zombie;
            ATK = 1600;
            DEF = 0;
            CardCode = 66672569;
            Description = "A dragon revived by sorcery. Its breath is highly corrosive.";
        }
    }
}
