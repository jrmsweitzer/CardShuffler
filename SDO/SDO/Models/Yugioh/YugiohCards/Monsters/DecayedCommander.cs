using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DecayedCommander : EffectMonster
    {
        public DecayedCommander(YugiohGame game) : base(game)
        {
            Name = "Decayed Commander";
            SetCodes.Add("SBLS-EN032");
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Zombie;
            ATK = 1000;
            DEF = 1500;
            CardCode = 10209545;
            Description = "When this card is Normal Summoned: You can Special Summon 1 \"Zombie Tiger\" from your hand. If this card inflicts battle damage to your opponent by a direct attack: Discard 1 random card from their hand.";
        }
    }
}
