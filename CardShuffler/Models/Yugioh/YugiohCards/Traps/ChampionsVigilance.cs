using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ChampionsVigilance : CounterTrap
    {
        public ChampionsVigilance(YugiohGame game) : base(game)
        {
            Name = "Champion's Vigilance";
        }
    }
}
