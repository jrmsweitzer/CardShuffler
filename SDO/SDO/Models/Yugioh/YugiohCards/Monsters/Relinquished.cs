using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Relinquished : RitualMonster
    {
        public Relinquished(YugiohGame game) : base(game)
        {
            Name = "Relinquished";
            RitualSpellCardName = "Black Illusion Ritual";
            SetCodes.Add("SS01-ENC08");
            Attribute = MonsterAttribute.Dark;
            Type = MonsterType.Spellcaster;
            ATK = 0;
            DEF = 0;
            CardCode = 64631466;
            Description = "You can Ritual Summon this card with \"Black Illusion Ritual\". Once per turn: You can target 1 monster your opponent controls; equip that target to this card. (max. 1). This card's ATK/DEF become equal to that equipped monster's. If this card would be destroyed by battle, destroy that equipped monster instead. While equipped with that monster, any battle damage you take from battles involving this card inflicts equal effect damage to your opponent.";
        }
    }
}
