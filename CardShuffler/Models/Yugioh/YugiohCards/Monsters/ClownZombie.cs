using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ClownZombie : NormalMonster
    {
        public ClownZombie(YugiohGame game) : base(game)
        {
            Name = "Clown Zombie";
            SetCodes.Add("SBLS-EN029");
        }
    }
}
