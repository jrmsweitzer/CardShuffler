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
        }
    }
}
