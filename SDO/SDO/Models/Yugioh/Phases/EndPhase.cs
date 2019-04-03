using System;

namespace SDO.Models.Yugioh.Phases
{
    public class EndPhase
    {
        public void Execute(YugiohGamePlayer player)
        {
            Console.WriteLine($"{player.Name} entered End Phase");
        }
    }
}
