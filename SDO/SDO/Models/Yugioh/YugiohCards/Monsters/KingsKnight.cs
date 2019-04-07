using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class KingsKnight : EffectMonster
    {
        public KingsKnight(YugiohGame game) : base(game)
        {
            Name = "King's Knight";
            SetCodes.Add("SBLS-EN005");
            Description = "When this card is Normal Summoned while you control \"Queen's Knight\": You can Special Summon 1 \"Jack's Knight\" from your Deck.";
            ATK = 1600;
            DEF = 1400;
            Attribute = MonsterAttribute.Light;
            Level = 4;
            Type = MonsterType.Warrior;
            CardCode = 64788463;
        }
    }
}
