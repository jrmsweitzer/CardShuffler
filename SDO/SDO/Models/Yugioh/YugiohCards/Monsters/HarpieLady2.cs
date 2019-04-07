using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class HarpieLady2 : EffectMonster
    {
        public HarpieLady2(YugiohGame game) : base(game)
        {
            Name = "Harpie Lady 2";
            Attribute = MonsterAttribute.Wind;
            Level = 4;
            Type = MonsterType.WingedBeast;
            ATK = 1300;
            DEF = 1400;
            SetCodes.Add("SS02-ENC02");
            CardCode = 27927359;
            Description = "(This card's name is always treated as \"Harpie Lady\".)\n" +
"Negate the effects of Flip monsters this card destroys by battle.";
        }
    }
}
