using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LastGamble : Skill
    {
        public LastGamble(YugiohGame game) : base(game)
        {
            Name = "Last Gamble";
            Character = "Joey";
            SetCodes.Add("SS02-ENBS2");
        }
    }
}
