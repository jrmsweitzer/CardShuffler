using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ItsaToonWorld : Skill
    {
        public ItsaToonWorld(YugiohGame game) : base(game)
        {
            Name = "It's a Toon World!";
            Character = "Pegasus";
            SetCodes.Add("SS01-ENCS1");
            SkillActivationDescription = "At the start of the Duel, place this card in your center Spell & Trap Zone and flip it over.";
            Description = "This card is treated as \"Toon World\".";
        }
    }
}
