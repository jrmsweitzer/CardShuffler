using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class RoyalFlush : Skill
    {
        public RoyalFlush(YugiohGame game) : base(game)
        {
            Name = "Royal Flush";
            Character = "Yami Yugi";
            SetCodes.Add("SBLS-ENS04");
        }
    }
}
