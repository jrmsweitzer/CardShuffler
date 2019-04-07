using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TyrantDragon : EffectMonster
    {
        public TyrantDragon(YugiohGame game) : base(game)
        {
            Name = "Tyrant Dragon";
            Attribute = MonsterAttribute.Fire;
            Level = 8;
            Type = MonsterType.Dragon;
            ATK = 2900;
            DEF = 2500;
            SetCodes.Add("SS02-ENA07");
            CardCode = 94568601;
            Description = "During your Battle Phase, if your opponent controls a monster after this card's first attack, this card can make a second attack. Negate any Trap effects that target this card on the field, and if you do, destroy that Trap. This card cannot be Special Summoned from the GY, unless you Tribute 1 Dragon monster.";
        }
    }
}
