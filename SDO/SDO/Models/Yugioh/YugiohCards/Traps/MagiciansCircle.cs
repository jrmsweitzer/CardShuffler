using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MagiciansCircle : NormalTrap
    {
        public MagiciansCircle(YugiohGame game) : base(game)
        {
            Name = "Magician's Circle";
            SetCodes.Add("SS01-ENA16");
        }
    }
}
