namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class CounterTrap: Trap
    {
        public CounterTrap(YugiohGame game) : base(game)
        {
            TrapType = TrapType.Counter;
        }

        public override string ToString()
        {
            return $"{Name} - Counter Trap";
        }

        
    }
}
