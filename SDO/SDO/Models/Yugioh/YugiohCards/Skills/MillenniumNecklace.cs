using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MillenniumNecklace : Skill
    {
        public MillenniumNecklace(YugiohGame game) : base(game)
        {
            Name = "Millennium Necklace";
            Character = "Ishizu";
            SetCodes.Add("SS01-ENBS3");
            Description = "At the start of the opponent's turn, before they draw, you may look at the top 3 cards of their Deck and rearrange them in any order.\n" +
"This Skill can only be used once per Duel.";
        }
    }
}
