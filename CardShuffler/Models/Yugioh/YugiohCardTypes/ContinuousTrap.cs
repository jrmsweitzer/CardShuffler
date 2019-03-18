namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public class ContinuousTrap: Trap
    {
        public ContinuousTrap(YugiohGame game) : base(game)
        {
            TrapType = TrapType.Continuous;
        }
    }
}
