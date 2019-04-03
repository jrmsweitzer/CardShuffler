using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class KingoftheSkullServants : EffectMonster
    {
        public KingoftheSkullServants(YugiohGame game) : base(game)
        {
            Name = "King of the Skull Servants";
            SetCodes.Add("SBLS-EN031");
        }
    }
}
