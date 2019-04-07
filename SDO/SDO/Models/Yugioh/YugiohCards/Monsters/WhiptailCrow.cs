using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class WhiptailCrow : NormalMonster
    {
        public WhiptailCrow(YugiohGame game) : base(game)
        {
            Name = "Whiptail Crow";
            SetCodes.Add("SBLS-EN002");
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Fiend;
            ATK = 1650;
            DEF = 1600;
            CardCode = 91996584;
            Description = "Attacks from the skies with a whip-like tail.";
        }
    }
}
