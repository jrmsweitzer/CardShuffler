using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MysticHorseman : NormalMonster
    {
        public MysticHorseman(YugiohGame game) : base(game)
        {
            Name = "Mystic Horseman";
            SetCodes.Add("SBLS-EN010");
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Beast;
            ATK = 1300;
            DEF = 1550;
            CardCode = 68516705;
            Description = "Half man and half horse, this monster is known for its extreme speed.";
        }
    }
}
