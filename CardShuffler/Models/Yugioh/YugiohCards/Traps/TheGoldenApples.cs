using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class TheGoldenApples : NormalTrap
    {
        public TheGoldenApples(YugiohGame game) : base(game)
        {
            Name = "The Golden Apples";
            SetCodes.Add("SS01-ENV02");
        }
    }
}
