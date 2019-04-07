using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ArmoredZombie : NormalMonster
    {
        public ArmoredZombie(YugiohGame game) : base(game)
        {
            Name = "Armored Zombie";
            SetCodes.Add("SBLS-EN027");
            Attribute = MonsterAttribute.Dark;
            Level = 3;
            Type = MonsterType.Zombie;
            ATK = 1500;
            DEF = 0;
            CardCode = 20277860;
            Description = "This warrior blindly swings a deadly blade with devastating force.";
        }
    }
}
