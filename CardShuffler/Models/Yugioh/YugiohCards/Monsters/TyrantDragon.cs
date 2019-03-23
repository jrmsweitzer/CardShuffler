using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class TyrantDragon : EffectMonster
    {
        public TyrantDragon(YugiohGame game) : base(game)
        {
            Name = "Tyrant Dragon";
        }
    }
}
