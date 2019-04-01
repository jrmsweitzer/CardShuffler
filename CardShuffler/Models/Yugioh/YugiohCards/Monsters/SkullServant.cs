using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class SkullServant : NormalMonster
    {
        public SkullServant(YugiohGame game) : base(game)
        {
            Name = "Skull Servant";
            SetCodes.Add("SBLS-EN025");
        }
    }
}
