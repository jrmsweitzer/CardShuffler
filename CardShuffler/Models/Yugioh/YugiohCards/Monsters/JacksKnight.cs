using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class JacksKnight : NormalMonster
    {
        public JacksKnight(YugiohGame game) : base(game)
        {
            Name = "Jack's Knight";
            SetCodes.Add("SBLS-EN006");
        }
    }
}
