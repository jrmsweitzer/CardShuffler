using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SphereKuriboh : EffectMonster
    {
        public SphereKuriboh(YugiohGame game) : base(game)
        {
            Name = "Sphere kuriboh";
            Attribute = MonsterAttribute.Dark;
            Level = 1;
            Type = MonsterType.Fiend;
            ATK = 300;
            DEF = 200;
            SetCodes.Add("SBLS-EN018");
            CardCode = 33245030;
        }
    }
}
