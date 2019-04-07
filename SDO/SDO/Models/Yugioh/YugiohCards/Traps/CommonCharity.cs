using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class CommonCharity : NormalTrap
    {
        public CommonCharity(YugiohGame game) : base(game)
        {
            Name = "Common Charity";
            SetCodes.Add("SBLS-EN016");
            CardCode = 40465719;
            Description = "Draw 2 cards, then banish 1 Normal Monster from your hand, or, if you have none, send your entire hand to the GY.";
        }
    }
}
