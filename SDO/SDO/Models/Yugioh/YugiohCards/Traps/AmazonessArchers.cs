using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AmazonessArchers : NormalTrap
    {
        public AmazonessArchers(YugiohGame game) : base(game)
        {
            Name = "Amazoness Archers";
            SetCodes.Add("SS02-ENC15");
            CardCode = 67987611;
            Description = "When an opponent's monster declares an attack, while you control an \"Amazoness\" monster: Change all monsters your opponent currently controls to face-up Attack Position (Flip Effects are not activated), they lose 500 ATK, also they must attack this turn, if able.";
        }
    }
}
