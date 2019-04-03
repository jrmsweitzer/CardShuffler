using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GreatMammothofGoldfine : NormalFusionMonster
    {
        public GreatMammothofGoldfine(YugiohGame game) : base(game)
        {
            Name = "Great Mammoth of Goldfine";
            SetCodes.Add("SBLS-EN034");
        }
    }
}
