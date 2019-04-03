using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LightforceSword : NormalTrap
    {
        public LightforceSword(YugiohGame game) : base(game)
        {
            Name = "Lightforce Sword";
            SetCodes.Add("SS01-ENA15");
        }
    }
}
