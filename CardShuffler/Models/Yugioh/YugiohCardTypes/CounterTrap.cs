﻿namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public class CounterTrap: Trap
    {
        public CounterTrap(YugiohGame game) : base(game)
        {
            TrapType = TrapType.Counter;
        }

        public override bool CanActivate() => throw new System.NotImplementedException();
    }
}
