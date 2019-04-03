using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Michizure : NormalTrap
    {
        public Michizure(YugiohGame game) : base(game)
        {
            Name = "Michizure";
            SetCodes.Add("SBLS-EN044");
            CardCode = 37580756;
        }
    }
}
