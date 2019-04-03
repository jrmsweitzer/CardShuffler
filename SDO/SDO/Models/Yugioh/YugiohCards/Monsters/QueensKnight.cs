using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class QueensKnight : NormalMonster
    {
        public QueensKnight(YugiohGame game) : base(game)
        {
            Name = "Queen's Knight";
            SetCodes.Add("SBLS-EN004");
        }
    }
}
