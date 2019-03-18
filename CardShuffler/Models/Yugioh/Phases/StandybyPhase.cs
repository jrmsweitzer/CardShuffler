using System;
using System.Diagnostics;

namespace CardShuffler.Models.Yugioh.Phases
{
    public class StandybyPhase
    {
        public void Execute(YugiohGamePlayer player)
        {
            Console.WriteLine($"{player.Name} entered Standby Phase");
        }
    }
}
