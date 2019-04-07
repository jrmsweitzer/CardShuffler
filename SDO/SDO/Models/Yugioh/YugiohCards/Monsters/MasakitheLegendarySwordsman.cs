using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MasakitheLegendarySwordsman : NormalMonster
    {
        public MasakitheLegendarySwordsman(YugiohGame game) : base(game)
        {
            Name = "Masaki the Legendary Swordsman";
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Warrior;
            ATK = 1100;
            DEF = 1100;
            CardCode = 44287299;
            SetCodes.Add("SS02-ENB04");
            Description = "Legendary swordmaster Masaki is a veteran of over 100 battles.";
        }
    }
}
