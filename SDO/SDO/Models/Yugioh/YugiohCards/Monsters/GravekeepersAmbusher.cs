using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersAmbusher : EffectMonster
    {
        public GravekeepersAmbusher(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Ambusher";
            SetCodes.Add("SBLS-EN022");
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1700;
            DEF = 0;
            CardCode = 22134079;
            Description = "When this card is flipped face-up: You can target 1 card in your opponent's GY; place that target on the bottom of their Deck. If this card is sent from the field to the GY after being flipped face-up: You can target 1 \"Necrovalley\" card in your GY; add that target to your hand. These effects are unaffected by \"Necrovalley\".";
        }
    }
}
