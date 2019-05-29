using System.Collections.Generic;
using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ToonRollback : NormalSpell
    {
        public ToonRollback(YugiohGame game) : base(game)
        {
            Name = "Toon Rollback";
            SetCodes.Add("SS01-ENC11");
            CardCode = 70560957;
            Description = "Target 1 Toon monster you control; it can make a second attack during each Battle Phase this turn.";
        }
    }
}
