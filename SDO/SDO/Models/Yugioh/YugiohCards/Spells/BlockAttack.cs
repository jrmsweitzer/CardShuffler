using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BlockAttack : NormalSpell
    {
        public BlockAttack(YugiohGame game) : base(game)
        {
            Name = "Block Attack";
            SetCodes.Add("SBLS-EN038");
            CardCode = 25880422;
            Description = "Target 1 face-up Attack Position monster your opponent controls; change that target to face-up Defense Position.";
        }

        
        
        
        
        
    }
}
