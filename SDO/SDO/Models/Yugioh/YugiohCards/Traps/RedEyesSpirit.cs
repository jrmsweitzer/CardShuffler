using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class RedEyesSpirit : NormalTrap
    {
        public RedEyesSpirit(YugiohGame game) : base(game)
        {
            Name = "Red-Eyes Spirit";
            SetCodes.Add("SS02-ENB19");
            CardCode = 44397496;
            Description = "Target 1 \"Red-Eyes\" monster in your GY; Special Summon it.";
        }
    }
}
