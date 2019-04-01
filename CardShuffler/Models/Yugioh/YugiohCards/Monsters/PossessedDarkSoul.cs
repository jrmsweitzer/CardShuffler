using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
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
