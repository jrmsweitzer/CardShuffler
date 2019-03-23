namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public class ContinuousTrap: Trap
    {
        public ContinuousTrap(YugiohGame game) : base(game)
        {
            TrapType = TrapType.Continuous;
        }

        public override bool CanActivate() => throw new System.NotImplementedException();
    }
}
