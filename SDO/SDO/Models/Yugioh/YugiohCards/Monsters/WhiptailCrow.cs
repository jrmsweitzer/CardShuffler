using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class WhiptailCrow : NormalMonster
    {
        public WhiptailCrow(YugiohGame game) : base(game)
        {
            Name = "Whiptail Crow";
            SetCodes.Add("SBLS-EN002");
        }
    }
}
