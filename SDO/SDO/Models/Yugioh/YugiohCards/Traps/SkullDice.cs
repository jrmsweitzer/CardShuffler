using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SkullDice : NormalTrap
    {
        public SkullDice(YugiohGame game) : base(game)
        {
            Name = "Skull Dice";
            SetCodes.Add("SS02-ENB17");
        }
    }
}
