using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh
{
    public class YugiohGame : Game
    {
        public YugiohGame() : base()
        {
        }

        public bool IsGameOver()
        {
            if (Turn == 0) return false;
            // Starting player decked out
            if (P1.Deck.MainDeckCards.Count == 0) return true;
            // Starting player is out of LP
            if (((YugiohGamePlayer)P1).LifePoints <= 0) return true;
            // Opponent decked out
            if (P2.Deck.MainDeckCards.Count == 0) return true;
            // Opponent is out of LP
            if (((YugiohGamePlayer)P2).LifePoints <= 0) return true;
            return false;
        }

        public List<YugiohFieldBuff> FieldBuffs { get; set; } = new List<YugiohFieldBuff>();

        public void Start()
        {
            ((YugiohGamePlayer)P1).LifePoints = 4000;
            ((YugiohGamePlayer)P2).LifePoints = 4000;
            Start(4);
        }

        public void Play()
        {
            try
            {
                while (!IsGameOver())
                {
                    Turn++;
                    if (Turn % 2 == 1)
                    {
                        TurnPlayer = P1;
                        Opponent = P2;
                    }
                    else
                    {
                        TurnPlayer = P2;
                        Opponent = P1;
                    }
                    ((YugiohGamePlayer)TurnPlayer).PlayTurn(this, Turn);
                }

                if (P1.Deck.MainDeckCards.Count == 0 ||
                    ((YugiohGamePlayer)P1).LifePoints <= 0)
                    Console.WriteLine($"{P2.Name} won!");
                else if (P2.Deck.MainDeckCards.Count == 0 ||
                    ((YugiohGamePlayer)P2).LifePoints <= 0)
                    Console.WriteLine($"{P1.Name} won!");


            }
            catch (Exception ex)
            {
                // TODO: Handle exception gracefully
                throw ex;
            }
        }
    }
}
