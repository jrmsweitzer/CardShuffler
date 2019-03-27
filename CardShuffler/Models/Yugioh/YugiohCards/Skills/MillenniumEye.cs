using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class MillenniumEye : Skill
    {
        public MillenniumEye(YugiohGame game) : base(game)
        {
            Name = "Millennium Eye";
            Character = "Pegasus";
            SetCodes.Add("SS01-ENCS3");
        }
    }
}
