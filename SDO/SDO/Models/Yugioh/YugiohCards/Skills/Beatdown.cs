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
            Description = "If you control a Level 5 or higher monster, you can activate this Skill.\n" +
                    "All monsters you currently control gain 300 ATK for each Level 5 or higher monster you control.At the end of your turn, flip this card over.";
        }
    }
}
