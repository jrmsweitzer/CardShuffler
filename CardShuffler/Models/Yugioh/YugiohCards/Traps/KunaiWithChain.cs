using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class KunaiWithChain : NormalTrap
    {
        public KunaiWithChain(YugiohGame game) : base(game)
        {
            Name = "Kunai With Chain";
        }

        public override string ToString()
        {
            return $"{Name} - Counter Trap";
        }

        public override bool CanActivate() => throw new NotImplementedException();
    }
}
