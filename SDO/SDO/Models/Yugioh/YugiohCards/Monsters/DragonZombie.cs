using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DragonZombie : NormalMonster
    {
        public DragonZombie(YugiohGame game) : base(game)
        {
            Name = "Dragon Zombie";
            SetCodes.Add("SBLS-EN028");
        }
    }
}
