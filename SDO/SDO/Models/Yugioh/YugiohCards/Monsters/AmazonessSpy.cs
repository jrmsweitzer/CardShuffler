using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AmazonessSpy : EffectMonster
    {
        public AmazonessSpy(YugiohGame game) : base(game)
        {
            Name = "Amazoness Spy";
            SetCodes.Add("SBLS-EN021");
            Attribute = MonsterAttribute.Earth;
            Level = 3;
            Type = MonsterType.Warrior;
            ATK = 800;
            DEF = 1200;
            CardCode = 31102447;
            Description = "You can reveal 1 other \"Amazoness\" monster in your hand; Special Summon this card from your hand. You can only use this effect of \"Amazoness Spy\" once per turn. When this card is destroyed by battle and sent to the GY: You can target 1 \"Amazoness\" monster in your GY, except \"Amazoness Spy\"; return it to the hand, or shuffle it into the Deck.";
        }
    }
}
