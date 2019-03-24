using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
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
        }
    }
}
