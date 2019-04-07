using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TombofthePharaoh : Skill
    {
        public TombofthePharaoh(YugiohGame game) : base(game)
        {
            Name = "Tomb of the Pharoah";
            Character = "Ishizu";
            SetCodes.Add("SBLS-ENS06");
            SkillActivationDescription = "At the start of the Duel, place this card in your Field Zone and flip it over.";
            Description = "This card's name is always treated as \"Necrovalley\".\n" +
"All \"Gravekeeper's\" monsters on the field gain 200 ATK / DEF.";
        }
    }
}
