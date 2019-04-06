using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MagiciansCircle : NormalTrap
    {
        public MagiciansCircle(YugiohGame game) : base(game)
        {
            Name = "Magician's Circle";
            SetCodes.Add("SS01-ENA16");
            CardCode = 00050755;
            Description = "When a Spellcaster-Type monster declares an attack: Each player Special Summons 1 Spellcaster-Type monster with 2000 or less ATK from their Deck in Attack Position.";
        }
    }
}
