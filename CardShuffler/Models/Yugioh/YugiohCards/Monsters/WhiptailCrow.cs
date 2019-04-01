using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class WhiptailCrow : NormalMonster
    {
        public WhiptailCrow(YugiohGame game) : base(game)
        {
            Name = "Whiptail Crow";
            SetCodes.Add("SBLS-EN002");
        }
    }
}
