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
            Description = "When this card is destroyed by battle and sent to the GY: You can pay 1500 LP; look at your opponent's hand, then add 1 monster from their hand to your hand.";
        }
    }
}
