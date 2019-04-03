using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TrapJammer : CounterTrap
    {
        public TrapJammer(YugiohGame game) : base(game)
        {
            Name = "Trap Jammer";
            SetCodes.Add("SS02-ENA17");
        }
    }
}
