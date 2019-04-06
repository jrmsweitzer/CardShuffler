using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class JarofGreed : NormalTrap
    {
        public JarofGreed(YugiohGame game) : base(game)
        {
            Name = "Jar of Greed";
            SetCodes.Add("SS01-ENC16");
            CardCode = 83968380;
            Description = "Draw 1 card.";
        }
    }
}
