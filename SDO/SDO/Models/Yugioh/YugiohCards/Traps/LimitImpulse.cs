using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LimitImpulse : NormalTrap
    {
        public LimitImpulse(YugiohGame game) : base(game)
        {
            Name = "Limit Impulse";
            SetCodes.Add("SBLS-EN045");
            CardCode = 82324105;
            Description = "Send 2 cards from your hand to the GY; Special Summon 2 \"Soul Tokens\" (Fiend/DARK/Level 1/ATK 0/DEF 0). They cannot be Tributed except for a Tribute Summon.";
        }
    }
}
