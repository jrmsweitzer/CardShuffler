using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TheSnakeHair : NormalMonster
    {
        public TheSnakeHair(YugiohGame game) : base(game)
        {
            Name = "The Snake Hair";
            SetCodes.Add("SBLS-EN026");
        }
    }
}
