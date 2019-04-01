using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class MagicalGhost : NormalMonster
    {
        public MagicalGhost(YugiohGame game) : base(game)
        {
            Name = "Magical Ghost";
            SetCodes.Add("SBLS-EN030");
        }
    }
}
