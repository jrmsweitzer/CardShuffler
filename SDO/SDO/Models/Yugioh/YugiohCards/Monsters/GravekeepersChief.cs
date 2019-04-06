using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersChief : EffectMonster
    {
        public GravekeepersChief(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Chief";
            Attribute = MonsterAttribute.Dark;
            Level = 6;
            Type = MonsterType.Spellcaster;
            ATK = 1900;
            DEF = 1200;
            SetCodes.Add("SS01-ENB04");
            CardCode = 62473983;
            Description = "You can only control 1 face-up \"Gravekeeper's Chief\". Your Graveyard is unaffected by \"Necrovalley\". When this card is Tribute Summoned: You can target 1 \"Gravekeeper's\" monster in your Graveyard; Special Summon that target.";
        }
    }
}
