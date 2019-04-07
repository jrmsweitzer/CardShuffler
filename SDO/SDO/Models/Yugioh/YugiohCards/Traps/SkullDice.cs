using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SkullDice : NormalTrap
    {
        public SkullDice(YugiohGame game) : base(game)
        {
            Name = "Skull Dice";
            SetCodes.Add("SS02-ENB17");
            CardCode = 00126218;
            Description = "Roll a six-sided die. All monsters your opponent currently controls lose ATK/DEF equal to the result x 100, until the end of this turn.";
        }
    }
}
