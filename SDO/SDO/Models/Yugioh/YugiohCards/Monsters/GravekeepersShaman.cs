using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersShaman : EffectMonster
    {
        public GravekeepersShaman(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Shaman";
            Attribute = MonsterAttribute.Dark;
            Level = 6;
            Type = MonsterType.Spellcaster;
            ATK = 1500;
            DEF = 1500;
            SetCodes.Add("SS01-ENB09");
            CardCode = 58139128;
            Description = "This card gains 200 DEF for each \"Gravekeeper's\" monster in your Graveyard. Negate all monster effects that activate in the Graveyard, except "Gravekeeper's" monsters. While \"Necrovalley\" is on the field, your opponent cannot activate Field Spell Cards, also Field Spell Cards on the field cannot be destroyed by your opponent's card effects.";
        }
    }
}
