using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ClownZombie : NormalMonster
    {
        public ClownZombie(YugiohGame game) : base(game)
        {
            Name = "Clown Zombie";
            SetCodes.Add("SBLS-EN029");
        }
    }
}
