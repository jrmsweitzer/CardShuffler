using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BusterBlader : EffectMonster
    {
        public BusterBlader(YugiohGame game) : base(game)
        {
            Name = "Buster Blader";
            SetCodes.Add("SBLS-EN001");
            Attribute = MonsterAttribute.Earth;
            Level = 7;
            Type = MonsterType.Warrior;
            ATK = 2600;
            DEF = 2300;
            CardCode = 78193831;
            Description = "Gains 500 ATK for each Dragon monster your opponent controls or is in their GY.";
        }
    }
}
