using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DragonsRebirth : NormalTrap
    {
        public DragonsRebirth(YugiohGame game) : base(game)
        {
            Name = "Dragon's Rebirth";
            SetCodes.Add("SS02-ENA16");
        }
    }
}
