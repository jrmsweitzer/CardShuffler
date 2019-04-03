using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Conscription : NormalTrap
    {
        public Conscription(YugiohGame game) : base(game)
        {
            Name = "Conscription";
            SetCodes.Add("SBLS-EN024");
        }
    }
}
