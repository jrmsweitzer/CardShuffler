using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AmazonessChainMaster : EffectMonster
    {
        public AmazonessChainMaster(YugiohGame game) : base(game)
        {
            Name = "Amazoness Chain Master";
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Warrior;
            ATK = 1500;
            DEF = 1300;
            SetCodes.Add("SS02-ENC05");
            CardCode = 29654737;
        }
    }
}
