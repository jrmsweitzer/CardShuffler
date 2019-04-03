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
        }
    }
}
