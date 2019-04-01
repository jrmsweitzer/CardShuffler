using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class KingsKnight : EffectMonster
    {
        public KingsKnight(YugiohGame game) : base(game)
        {
            Name = "King's Knight";
            SetCodes.Add("SBLS-EN005");
        }
    }
}
