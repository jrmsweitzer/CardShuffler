using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DecayedCommander : EffectMonster
    {
        public DecayedCommander(YugiohGame game) : base(game)
        {
            Name = "Decayed Commander";
            SetCodes.Add("SBLS-EN032");
        }
    }
}
