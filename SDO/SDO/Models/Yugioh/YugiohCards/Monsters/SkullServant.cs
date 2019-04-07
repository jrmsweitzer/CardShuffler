using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SkullServant : NormalMonster
    {
        public SkullServant(YugiohGame game) : base(game)
        {
            Name = "Skull Servant";
            SetCodes.Add("SBLS-EN025");
            Attribute = MonsterAttribute.Dark;
            Level = 1;
            Type = MonsterType.Zombie;
            ATK = 300;
            DEF = 200;
            CardCode = 32274490;
            Description = "A skeletal ghost that isn't strong but can mean trouble in large numbers.";
        }
    }
}
