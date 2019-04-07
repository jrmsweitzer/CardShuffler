using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TrapJammer : CounterTrap
    {
        public TrapJammer(YugiohGame game) : base(game)
        {
            Name = "Trap Jammer";
            SetCodes.Add("SS02-ENA17");
            CardCode = 19252988;
            Description = "When your opponent activates a Trap Card during the Battle Phase: Negate the activation, and if you do, destroy it.";
        }
    }
}
