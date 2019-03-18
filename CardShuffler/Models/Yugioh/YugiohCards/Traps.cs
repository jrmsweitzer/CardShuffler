using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class TrapList
    {
        public static List<YugiohGameCard> GetTraps(YugiohGame game)
        {
            return new List<YugiohGameCard>()
            {
                // A
                // B
                // C
                new CounterTrap(game)
                {
                    Name = "Champion's Vigilance"
                },
                // D
                // E
                // F
                // G
                // H
                // I
                // J
                // K
                new NormalTrap(game)
                {
                    Name = "Kunai With Chain"
                },
                // L
                // M
                // N
                // O
                // P
                // Q
                // R
                // S
                // T
                // U
                // V
                // W
                new NormalTrap(game)
                {
                    Name = "Windstorm of Etaqua"
                }
                // X
                // Y
                // Z
            };
        }
    }
}
