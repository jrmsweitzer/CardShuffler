using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ToonMaskedSorcerer : EffectMonster
    {
        public ToonMaskedSorcerer(YugiohGame game) : base(game)
        {
            Name = "Toon Masked Sorcerer";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 900;
            DEF = 1400;
            SetCodes.Add("SS01-ENC05");
            CardCode = 16392422;
            Description = "Cannot attack the turn it is Summoned. If \"Toon World\" on the field is destroyed, destroy this card. While you control \"Toon World\" and your opponent controls no Toon monsters, this card can attack your opponent directly. If this card inflicts battle damage to your opponent: Draw 1 card.";
        }
    }
}
