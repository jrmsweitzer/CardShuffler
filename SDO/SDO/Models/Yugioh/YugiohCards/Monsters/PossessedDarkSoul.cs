using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class PossessedDarkSoul : EffectMonster
    {
        public PossessedDarkSoul(YugiohGame game) : base(game)
        {
            Name = "Possessed Dark Soul";
            SetCodes.Add("SBLS-EN003");
        }
    }
}
