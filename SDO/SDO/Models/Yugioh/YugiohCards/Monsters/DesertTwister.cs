using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
