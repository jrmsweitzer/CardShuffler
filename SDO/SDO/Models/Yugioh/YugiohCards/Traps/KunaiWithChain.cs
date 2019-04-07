using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class KunaiWithChain : NormalTrap
    {
        public KunaiWithChain(YugiohGame game) : base(game)
        {
            Name = "Kunai With Chain";
            SetCodes.Add("SS02-ENB18");
            CardCode = 37390589;
            Description = "Activate 1 or both of these effects (simultaneously).\n" +
"● When an opponent's monster declares an attack: Target the attacking monster; change that target to Defense Position.\n" +
"● Target 1 face - up monster you control; equip this card to that target. It gains 500 ATK.";
        }
    }
}
