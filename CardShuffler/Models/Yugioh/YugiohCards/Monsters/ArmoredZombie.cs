using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ArmoredZombie : NormalMonster
    {
        public ArmoredZombie(YugiohGame game) : base(game)
        {
            Name = "Armored Zombie";
            SetCodes.Add("SBLS-EN027");
        }
    }
}
