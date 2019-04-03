using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ArmoredZombie : NormalMonster
    {
        public ArmoredZombie(YugiohGame game) : base(game)
        {
            Name = "Armored Zombie";
            SetCodes.Add("SBLS-EN027");
        }
    }
}
