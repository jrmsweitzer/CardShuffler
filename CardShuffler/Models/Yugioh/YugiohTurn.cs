using CardShuffler.Models.Yugioh.Phases;
using System;
using System.Diagnostics;

namespace CardShuffler.Models.Yugioh
{
    public class YugiohTurn
    {
        private YugiohGamePlayer _player;
        private YugiohGame _game;
        private int _turnOfGame;
        public YugiohTurn(YugiohGamePlayer player, YugiohGame game, int turnCount)
        {
            _player = player;
            _turnOfGame = turnCount;
            _game = game;
        }

        public void Execute()
        {
            try
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Turn {_turnOfGame}: {_player.Name}'s turn");
                
                new DrawPhase().Execute(_player, _turnOfGame);

                new StandybyPhase().Execute(_player);
                new MainPhase1(_game).Execute(_player, _game);

                if (_turnOfGame > 1)
                    new BattlePhase().Execute(_player, ((YugiohGamePlayer)_game.Opponent));

                new EndPhase().Execute(_player);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
