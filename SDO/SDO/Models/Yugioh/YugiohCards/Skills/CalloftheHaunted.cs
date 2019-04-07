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
            SkillActivationDescription = "At the start of the Duel, place this card in your center Spell & Trap Zone. You cannot activate this Skill during your first turn of the Duel. You draw 1 less card at the beginning of the Duel.";
            Description = "Activate this card by targeting 1 monster in your GY; Special Summon that target in Attack Position. When this card leaves the field, destroy that monster. When that monster is destroyed, destroy this card.";
        }
    }
}
