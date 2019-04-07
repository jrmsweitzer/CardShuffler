using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class JacksKnight : NormalMonster
    {
        public JacksKnight(YugiohGame game) : base(game)
        {
            Name = "Jack's Knight";
            SetCodes.Add("SBLS-EN006");
            Attribute = MonsterAttribute.Light;
            Level = 5;
            Type = MonsterType.Warrior;
            ATK = 1900;
            DEF = 1000;
            CardCode = 90876561;
            Description = "A strong master swordsman. His loyalty is to justice, his duty to protect the weak.";
        }
    }
}
