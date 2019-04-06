using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersSpearSoldier : EffectMonster
    {
        public GravekeepersSpearSoldier(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Spear Soldier";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1500;
            DEF = 1000;
            SetCodes.Add("SS01-ENB02");
            CardCode = 63695531;
            Description = "If this card attacks a Defense Position monster, inflict piercing Battle Damage to your opponent.";
        }
    }
}
