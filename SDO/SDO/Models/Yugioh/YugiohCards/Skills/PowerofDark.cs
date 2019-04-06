using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class PowerofDark : Skill
    {
        public PowerofDark(YugiohGame game) : base(game)
        {
            Name = "Power of Dark";
            Character = "Yami Yugi";
            SetCodes.Add("SS01-ENAS1");
            SkillActivationDescription = "At the start of the Duel, place this card in your Field Spell Zone and flip it over.";
            Description = "All Fiend and Spellcaster monsters on the field gain 200 ATK/DEF, also all Fairy monsters on the field lose 200 ATK/DEF.";
        }
    }
}
