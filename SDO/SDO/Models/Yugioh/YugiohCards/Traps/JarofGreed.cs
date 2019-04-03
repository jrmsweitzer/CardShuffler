using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class JarofGreed : NormalTrap
    {
        public JarofGreed(YugiohGame game) : base(game)
        {
            Name = "Jar of Greed";
            SetCodes.Add("SS01-ENC16");
        }
    }
}
