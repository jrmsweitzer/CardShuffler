using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class CommonCharity : NormalTrap
    {
        public CommonCharity(YugiohGame game) : base(game)
        {
            Name = "Common Charity";
            SetCodes.Add("SBLS-EN016");
        }
    }
}
