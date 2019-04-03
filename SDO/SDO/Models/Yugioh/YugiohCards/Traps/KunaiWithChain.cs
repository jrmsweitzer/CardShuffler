using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class KunaiWithChain : NormalTrap
    {
        public KunaiWithChain(YugiohGame game) : base(game)
        {
            Name = "Kunai With Chain";
            SetCodes.Add("SS02-ENB18");
        }
    }
}
