using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersAssailant : EffectMonster
    {
        public GravekeepersAssailant(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Assailant";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1500;
            DEF = 1500;
            SetCodes.Add("SS01-ENB06");
            CardCode = 25262697;
            Description = "When this card declares an attack while \"Necrovalley\" is on the field: You can target 1 face-up monster your opponent controls; change that target's battle position.";
        }
    }
}
