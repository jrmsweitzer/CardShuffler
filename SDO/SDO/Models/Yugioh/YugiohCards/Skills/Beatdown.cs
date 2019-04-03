using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Beatdown : Skill
    {
        public Beatdown(YugiohGame game) : base(game)
        {
            Name = "Beatdown";
            Character = "Kaiba";
            SetCodes.Add("SS02-ENAS2");
        }
    }
}
