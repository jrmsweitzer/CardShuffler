using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TribalSynergy : Skill
    {
        public TribalSynergy(YugiohGame game) : base(game)
        {
            Name = "Tribal Synergy";
            Character = "Mai";
            SetCodes.Add("SS02-ENCS3");
        }
    }
}
