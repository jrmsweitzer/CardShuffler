using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersVassal : EffectMonster
    {
        public GravekeepersVassal(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Vassal";
            Attribute = MonsterAttribute.Dark;
            Level = 3;
            Type = MonsterType.Spellcaster;
            ATK = 700;
            DEF = 500;
            SetCodes.Add("SS01-ENB03");
            CardCode = 99690140;
            Description = "Any battle damage this card inflicts to your opponent is treated as effect damage instead.";
        }
    }
}
