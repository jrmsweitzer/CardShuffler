using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ToonDefense : ContinuousTrap
    {
        public ToonDefense(YugiohGame game) : base(game)
        {
            Name = "Toon Defense";
            SetCodes.Add("SS01-ENC15");
            CardCode = 43509019;
            Description = "When an opponent's monster declares an attack targeting a face-up Level 4 or lower Toon Monster you control: You can make the attack a direct attack instead.";
        }
    }
}
