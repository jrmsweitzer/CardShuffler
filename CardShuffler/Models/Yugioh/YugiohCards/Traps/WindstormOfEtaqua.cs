using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class WindstormofEtaqua : NormalTrap
    {
        public WindstormofEtaqua(YugiohGame game) : base(game)
        {
            Name = "Windstorm of Etaqua";
            SetCodes.Add("SS02-ENC16");
        }

        public override bool CanActivate()
        {
            if (TurnSet == Game.Turn)
                return false;
            if (Opponent.Field.GetMonsters().Count() == 0)
                return false;
            if (Opponent.Field.GetMonstersFaceUp().Count() == 0)
                return false;

            return true;
        }
    }
}
