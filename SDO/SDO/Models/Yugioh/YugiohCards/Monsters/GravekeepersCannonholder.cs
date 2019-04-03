using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersCannonholder : EffectMonster
    {
        public GravekeepersCannonholder(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Cannonholder";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1400;
            DEF = 1200;
            SetCodes.Add("SS01-ENB05");
            CardCode = 99877698;
        }
    }
}
