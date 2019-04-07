using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class QueensKnight : NormalMonster
    {
        public QueensKnight(YugiohGame game) : base(game)
        {
            Name = "Queen's Knight";
            SetCodes.Add("SBLS-EN004");
            Attribute = MonsterAttribute.Light;
            Level = 4;
            Type = MonsterType.Warrior;
            ATK = 1500;
            DEF = 1600;
            CardCode = 25652259;
            Description = "This knight catches her opponents off guard, dominating them with swift yet graceful attacks.";
        }
    }
}
