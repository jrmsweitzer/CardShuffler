using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MagicalGhost : NormalMonster
    {
        public MagicalGhost(YugiohGame game) : base(game)
        {
            Name = "Magical Ghost";
            SetCodes.Add("SBLS-EN030");
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Zombie;
            ATK = 1300;
            DEF = 1400;
            CardCode = 46474915;
            Description = "This creature casts a spell of terror and confusion just before attacking its enemies.";
        }
    }
}
