using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ShadowofEyes : NormalTrap
    {
        public ShadowofEyes(YugiohGame game) : base(game)
        {
            Name = "Shadow of Eyes";
            SetCodes.Add("SS02-ENC17");
        }
    }
}
