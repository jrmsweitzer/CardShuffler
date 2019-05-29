using System.Collections.Generic;
using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MagiciansUnite : NormalSpell
    {
        public MagiciansUnite(YugiohGame game) : base(game)
        {
            Name = "Magician's Unite";
            SetCodes.Add("SBLS-EN009");
            CardCode = 36045450;
            Description = "If you control 2 or more Attack Position Spellcaster monsters: Target 1 of them; its ATK becomes 3000 until the end of this turn, also for the rest of this turn after this card resolves, other Spellcaster monsters you control cannot attack.";
        }
    }
}
