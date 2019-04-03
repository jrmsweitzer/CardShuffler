using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersAmbusher : EffectMonster
    {
        public GravekeepersAmbusher(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Ambusher";
            SetCodes.Add("SBLS-EN022");
        }
    }
}
