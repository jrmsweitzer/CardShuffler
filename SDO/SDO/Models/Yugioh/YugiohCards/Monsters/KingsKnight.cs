using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
