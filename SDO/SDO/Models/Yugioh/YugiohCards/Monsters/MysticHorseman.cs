using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MysticHorseman : NormalMonster
    {
        public MysticHorseman(YugiohGame game) : base(game)
        {
            Name = "Mystic Horseman";
            SetCodes.Add("SBLS-EN010");
        }
    }
}
