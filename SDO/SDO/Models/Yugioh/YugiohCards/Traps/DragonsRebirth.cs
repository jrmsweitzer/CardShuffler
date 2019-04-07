using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DragonsRebirth : NormalTrap
    {
        public DragonsRebirth(YugiohGame game) : base(game)
        {
            Name = "Dragon's Rebirth";
            SetCodes.Add("SS02-ENA16");
            CardCode = 20638610;
            Description = "Target 1 Dragon monster you control; banish that target, and if you do, Special Summon 1 Dragon monster from your hand or GY.";
        }
    }
}
