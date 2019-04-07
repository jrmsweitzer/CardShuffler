using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class HarpiesPetDragon : EffectMonster
    {
        public HarpiesPetDragon(YugiohGame game) : base(game)
        {
            Name = "Harpie's Pet Dragon";
            SetCodes.Add("SBLS-EN020");
            Attribute = MonsterAttribute.Wind;
            Level = 7;
            Type = MonsterType.Dragon;
            ATK = 2000;
            DEF = 2500;
            CardCode = 52040216;
            Description = "Gains 300 ATK/DEF for each \"Harpie Lady\" on the field.";
        }
    }
}
