using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class KingoftheSkullServants : EffectMonster
    {
        public KingoftheSkullServants(YugiohGame game) : base(game)
        {
            Name = "King of the Skull Servants";
            SetCodes.Add("SBLS-EN031");
            Attribute = MonsterAttribute.Dark;
            Level = 1;
            Type = MonsterType.Zombie;
            ATK = 0;
            DEF = 0;
            CardCode = 36021814;
            Description = "The original ATK of this card is the combined number of \"King of the Skull Servants\" and \"Skull Servant\" in your GY x 1000. When this card is destroyed by battle and sent to the GY: You can banish 1 other \"King of the Skull Servants\" or 1 \"Skull Servant\" from your GY; Special Summon this card.";
        }
    }
}
