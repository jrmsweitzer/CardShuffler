using System;

namespace CardShuffler.Models.Yugioh.Phases
{
    public class MainPhase2
    {
        public void Execute(YugiohGamePlayer player)
        {
            Console.WriteLine($"{player.Name} entered Main Phase 2");
        }
    }
}
