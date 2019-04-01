using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class DesertTwister : EffectMonster
    {
        public DesertTwister(YugiohGame game) : base(game)
        {
            Name = "Desert Twister";
            SetCodes.Add("SBLS-EN019");
        }
    }
}
