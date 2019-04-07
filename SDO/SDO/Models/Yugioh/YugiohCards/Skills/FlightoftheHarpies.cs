using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class FlightoftheHarpies : Skill
    {
        public FlightoftheHarpies(YugiohGame game) : base(game)
        {
            Name = "Flight of the Harpies";
            Character = "Mai";
            SetCodes.Add("SS02-ENCS2");
            Description = "If you lose 1800 or more LP, you can activate this Skill during your next Draw Phase.\n" +
"During your Draw Phase, you may search your Deck for a \"Harpie\" card, reveal it to your opponent, and add it to your hand instead of drawing.If you do that, flip this card over.";
        }
    }
}
