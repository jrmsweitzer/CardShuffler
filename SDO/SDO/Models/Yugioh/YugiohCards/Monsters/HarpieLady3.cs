using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class HarpieLady3 : EffectMonster
    {
        public HarpieLady3(YugiohGame game) : base(game)
        {
            Name = "Harpie Lady 3";
            Attribute = MonsterAttribute.Wind;
            Level = 4;
            Type = MonsterType.WingedBeast;
            ATK = 1300;
            DEF = 1400;
            SetCodes.Add("SS02-ENC03");
            CardCode = 54415063;
            Description = "(This card's name is always treated as \"Harpie Lady\".)\n" +
"An opponent's monster that battles this card cannot declare an attack during your opponent's next 2 turns.";
        }
    }
}
