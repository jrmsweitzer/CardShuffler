using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class RedEyesSpirit : NormalTrap
    {
        public RedEyesSpirit(YugiohGame game) : base(game)
        {
            Name = "Red-Eyes Spirit";
            SetCodes.Add("SS02-ENB19");
        }
    }
}
