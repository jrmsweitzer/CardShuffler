using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public class NormalTrap: Trap
    {
        public NormalTrap(YugiohGame game) : base(game)
        {
            TrapType = TrapType.Normal;
        }
    }
}
