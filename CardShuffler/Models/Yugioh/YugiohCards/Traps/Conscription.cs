using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class Conscription : NormalTrap
    {
        public Conscription(YugiohGame game) : base(game)
        {
            Name = "Conscription";
            SetCodes.Add("SBLS-EN024");
        }
    }
}
