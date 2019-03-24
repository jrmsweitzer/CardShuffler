using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class WildTornado : NormalTrap
    {
        public WildTornado(YugiohGame game) : base(game)
        {
            Name = "Wild Tornado";
        }

        public override bool CanActivate() => throw new NotImplementedException();
    }
}
