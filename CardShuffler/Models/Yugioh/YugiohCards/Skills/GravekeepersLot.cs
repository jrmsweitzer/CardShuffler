using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class GravekeepersLot : Skill
    {
        public GravekeepersLot(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Lot";
            Character = "Ishizu";
            SetCodes.Add("SS01-ENBS2");
        }
    }
}
