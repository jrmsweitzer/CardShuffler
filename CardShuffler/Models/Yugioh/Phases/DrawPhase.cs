using System;
using System.Diagnostics;

namespace CardShuffler.Models.Yugioh.Phases
{
    public class DrawPhase: PlayerPhase
    {
        public void Execute(YugiohGamePlayer player, int turnOfGame)
        {
            Console.WriteLine($"{player.Name} entered Draw Phase");
            if (turnOfGame > 1)
            {
                var card = player.DrawCard();
                Console.WriteLine($"{player.Name} drew {card.Name}");
            }
        }
    }
}
