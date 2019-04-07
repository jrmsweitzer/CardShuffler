using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class PeakPerformance : Skill
    {
        public PeakPerformance(YugiohGame game) : base(game)
        {
            Name = "Peak Performance";
            Character = "Kaiba";
            SetCodes.Add("SS02-ENAS1");
            SkillActivationDescription = "At the start of the Duel, place this card in your Field Spell Zone and flip it over.";
            Description = "All Dragon, Winged Beast, and Thunder monsters on the field gain 200 ATK/DEF.";
        }
    }
}
