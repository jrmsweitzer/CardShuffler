using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ToonMermaid : EffectMonster
    {
        public ToonMermaid(YugiohGame game) : base(game)
        {
            Name = "Toon Mermaid";
            Attribute = MonsterAttribute.Water;
            Level = 4;
            Type = MonsterType.Aqua;
            ATK = 1400;
            DEF = 1500;
            SetCodes.Add("SS01-ENC06");
            CardCode = 65458948;
            Description = "Cannot be Normal Summoned/Set. Cannot be Special Summoned unless you control a face-up \"Toon World\". Must first be Special Summoned (from your hand) by Tributing the same number of monsters needed for a Tribute Summon (normally 0). This card cannot attack the turn it is Special Summoned. You must pay 500 Life Points to declare an attack with this monster. If \"Toon World\" on the field is destroyed, destroy this card. This card can attack your opponent directly, unless they control a Toon Monster. If they do control one, this card must target a Toon Monster for its attacks.";
        }
    }
}
