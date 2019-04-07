using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class InterdimensionalMatterTransporter : NormalTrap
    {
        public InterdimensionalMatterTransporter(YugiohGame game) : base(game)
        {
            Name = "Interdimensional Matter Transporter";
            SetCodes.Add("SS02-ENA15");
            CardCode = 36261276;
            Description = "Target 1 face-up monster you control; banish that target until the End Phase.";
        }
    }
}
