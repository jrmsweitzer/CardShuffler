using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BattleOx : NormalMonster
    {
        public BattleOx(YugiohGame game) : base(game)
        {
            Name = "Battle Ox";
            Attribute = MonsterAttribute.Earth;
            Type = MonsterType.BeastWarrior;
            ATK = 1700;
            DEF = 1000;
            Level = 4;
            SetCodes.Add("SS02-ENA02");
            CardCode = 05053103;
            Description = "A monster with tremendous power, it destroys enemies with a swing of its axe.";
        }
    }
}
