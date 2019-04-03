using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MillenniumNecklace : Skill
    {
        public MillenniumNecklace(YugiohGame game) : base(game)
        {
            Name = "Millennium Necklace";
            Character = "Ishizu";
            SetCodes.Add("SS01-ENBS3");
        }
    }
}
