using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class QueensKnight : NormalMonster
    {
        public QueensKnight(YugiohGame game) : base(game)
        {
            Name = "Queen's Knight";
            SetCodes.Add("SBLS-EN004");
        }
    }
}
