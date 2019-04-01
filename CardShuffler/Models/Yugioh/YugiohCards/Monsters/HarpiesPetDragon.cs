using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class HarpiesPetDragon : EffectMonster
    {
        public HarpiesPetDragon(YugiohGame game) : base(game)
        {
            Name = "Harpie's Pet Dragon";
            SetCodes.Add("SBLS-EN020");
        }
    }
}
