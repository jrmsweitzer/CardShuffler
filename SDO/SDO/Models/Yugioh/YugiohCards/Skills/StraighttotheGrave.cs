using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class StraighttotheGrave : Skill
    {
        public StraighttotheGrave(YugiohGame game) : base(game)
        {
            Name = "Straight to the Grave";
            Character = "Bonz";
            SetCodes.Add("SBLS-ENS02");
            SkillActivationDescription = "At the start of the Duel, place this card in your Field Zone and flip it over.";
            Description = "All Dinosaur, Zombie, and Rock monsters on the field gain 200 ATK/DEF.";
        }
    }
}
