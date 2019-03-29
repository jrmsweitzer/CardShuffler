using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class TrapJammer : CounterTrap
    {
        public TrapJammer(YugiohGame game) : base(game)
        {
            Name = "Trap Jammer";
        }
    }
}
