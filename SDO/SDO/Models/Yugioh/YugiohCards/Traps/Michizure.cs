using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Michizure : NormalTrap
    {
        public Michizure(YugiohGame game) : base(game)
        {
            Name = "Michizure";
            SetCodes.Add("SBLS-EN044");
            CardCode = 37580756;
            Description = "When a monster is sent from the field to your GY, even during the Damage Step: Target 1 monster on the field; destroy it.";
        }
    }
}
