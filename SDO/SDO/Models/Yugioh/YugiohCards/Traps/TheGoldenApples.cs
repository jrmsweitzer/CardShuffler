using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TheGoldenApples : NormalTrap
    {
        public TheGoldenApples(YugiohGame game) : base(game)
        {
            Name = "The Golden Apples";
            SetCodes.Add("SS01-ENV02");
            CardCode = 42671151;
            Description = "When you take battle damage while you control no monsters: Gain LP equal to the battle damage you took, and if you do, Special Summon 1 \"Malus Token\" (Fiend/DARK/Level 1/ATK ?/DEF ?). Its ATK/DEF are each equal to the amount of LP you gained by this effect.";
        }
    }
}
