using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Copycat : EffectMonster
    {
        public Copycat(YugiohGame game) : base(game)
        {
            Name = "Copycat";
            Attribute = MonsterAttribute.Light;
            Level = 1;
            Type = MonsterType.Spellcaster;
            ATK = 0;
            DEF = 0;
            SetCodes.Add("SS02-ENB09");
            CardCode = 26376390;
            Description = "If this card is Summoned: Target 1 face-up monster your opponent controls; this card's ATK/DEF become equal to that monster's original ATK/DEF.";
        }
    }
}
