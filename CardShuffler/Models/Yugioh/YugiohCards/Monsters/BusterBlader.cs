using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class BusterBlader : EffectMonster
    {
        public BusterBlader(YugiohGame game) : base(game)
        {
            Name = "Buster Blader";
            SetCodes.Add("SBLS-EN001");
        }
    }
}
