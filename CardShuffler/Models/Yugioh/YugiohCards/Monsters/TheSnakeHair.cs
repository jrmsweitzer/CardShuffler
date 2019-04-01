using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class TheSnakeHair : NormalMonster
    {
        public TheSnakeHair(YugiohGame game) : base(game)
        {
            Name = "The Snake Hair";
            SetCodes.Add("SBLS-EN026");
        }
    }
}
