using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class HarpieLadySisters : EffectMonster
    {
        public HarpieLadySisters(YugiohGame game) : base(game)
        {
            Name = "Harpie Lady Sisters";
            Attribute = MonsterAttribute.Wind;
            Level = 6;
            Type = MonsterType.WingedBeast;
            ATK = 1950;
            DEF = 2100;
            SetCodes.Add("SS02-ENC04");
            CardCode = 12206212;
            Description = "Cannot be Normal Summoned/Set. Must first be Special Summoned with \"Elegant Egotist\".";
        }
    }
}
