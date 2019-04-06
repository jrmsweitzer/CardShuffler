using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BlueDragonSummoner : EffectMonster
    {
        public BlueDragonSummoner(YugiohGame game) : base(game)
        {
            Name = "Blue Dragon Summoner";
            Attribute = MonsterAttribute.Wind;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1500;
            DEF = 600;
            SetCodes.Add("SS01-ENA08");
            CardCode = 55969226;
            Description = "If this card is sent from the field to the GY: You can add 1 Dragon, Warrior, or Spellcaster-Type Normal Monster from your Deck to your hand.";
        }
    }
}
