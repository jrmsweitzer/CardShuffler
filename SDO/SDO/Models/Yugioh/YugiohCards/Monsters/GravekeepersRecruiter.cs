using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersRecruiter : EffectMonster
    {
        public GravekeepersRecruiter(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Recruiter";
            Attribute = MonsterAttribute.Dark;
            Level = 3;
            Type = MonsterType.Spellcaster;
            ATK = 1200;
            DEF = 1500;
            SetCodes.Add("SS01-ENB08");
            CardCode = 93023479;
            Description = "When this card you control is sent to your Graveyard: Add 1 \"Gravekeeper's\" monster with 1500 or less DEF from your Deck to your hand.";
        }
    }
}
