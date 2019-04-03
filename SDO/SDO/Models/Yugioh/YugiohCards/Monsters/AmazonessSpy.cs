using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AmazonessSpy : EffectMonster
    {
        public AmazonessSpy(YugiohGame game) : base(game)
        {
            Name = "Amazoness Spy";
            SetCodes.Add("SBLS-EN021");
        }
    }
}
