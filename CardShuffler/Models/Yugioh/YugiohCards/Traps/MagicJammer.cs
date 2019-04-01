using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class MagicJammer : CounterTrap
    {
        public MagicJammer(YugiohGame game) : base(game)
        {
            Name = "Magic Jammer";
            SetCodes.Add("SS01-ENA17");
        }
    }
}
