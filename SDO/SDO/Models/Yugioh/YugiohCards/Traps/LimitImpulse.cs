using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LimitImpulse : NormalTrap
    {
        public LimitImpulse(YugiohGame game) : base(game)
        {
            Name = "Limit Impulse";
            SetCodes.Add("SBLS-EN045");
        }
    }
}
