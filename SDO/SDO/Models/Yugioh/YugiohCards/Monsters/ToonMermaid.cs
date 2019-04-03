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
        }
    }
}
