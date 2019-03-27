using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards.Traps
{
    public class Michizure : NormalTrap
    {
        public Michizure(YugiohGame game) : base(game)
        {
            Name = "Michizure";
            SetCodes.Add("SBLS-EN044");
            CardCode = 37580756;
        }
    }
}
