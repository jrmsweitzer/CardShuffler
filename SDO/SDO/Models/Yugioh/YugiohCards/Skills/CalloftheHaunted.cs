using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class CalloftheHaunted : Skill
    {
        public CalloftheHaunted(YugiohGame game) : base(game)
        {
            Name = "Call of the Haunted";
            Character = "Bonz";
            SetCodes.Add("SBLS-ENS03");
        }
    }
}
