using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ParrotDragon : NormalMonster
    {
        public ParrotDragon(YugiohGame game) : base(game)
        {
            Name = "Parrot Dragon";
            Attribute = MonsterAttribute.Wind;
            Level = 5;
            Type = MonsterType.Dragon;
            ATK = 2000;
            DEF = 1300;
            SetCodes.Add("SS01-ENC03");
            CardCode = 62762898;
            Description = "A dragon from the cartoons that's more dangerous than it appears to be.";
        }
    }
}
