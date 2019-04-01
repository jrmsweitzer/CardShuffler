using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class InterdimensionalMatterTransporter : NormalTrap
    {
        public InterdimensionalMatterTransporter(YugiohGame game) : base(game)
        {
            Name = "Interdimensional Matter Transporter";
            SetCodes.Add("SS02-ENA15");
        }
    }
}
