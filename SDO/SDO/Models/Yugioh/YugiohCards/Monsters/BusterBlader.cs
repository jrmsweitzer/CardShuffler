using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
