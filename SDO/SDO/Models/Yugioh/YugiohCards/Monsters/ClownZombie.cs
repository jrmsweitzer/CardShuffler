using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ClownZombie : NormalMonster
    {
        public ClownZombie(YugiohGame game) : base(game)
        {
            Name = "Clown Zombie";
            SetCodes.Add("SBLS-EN029");
            Attribute = MonsterAttribute.Dark;
            Level = 2;
            Type = MonsterType.Zombie;
            ATK = 1350;
            DEF = 0;
            CardCode = 92667214;
            Description = "A clown revived by the powers of darkness. Its deadly dance has sent many monsters to their graves.";
        }
    }
}
