using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ToonSummonedSkull : EffectMonster
    {
        public ToonSummonedSkull(YugiohGame game) : base(game)
        {
            Name = "Toon Summoned Skull";
            Attribute = MonsterAttribute.Dark;
            Level = 6;
            Type = MonsterType.Fiend;
            ATK = 2500;
            DEF = 1200;
            SetCodes.Add("SS01-ENC07");
            CardCode = 91842653;
            Description = "(This card is always treated as an \"Archfiend\" card.)\n" +
"Cannot be Normal Summoned/ Set.Cannot be Special Summoned unless you control \"Toon World\".Must first be Special Summoned(from your hand) by Tributing the same number of monsters needed for a Tribute Summon(normally 1).This card cannot attack the turn it is Special Summoned. You must pay 500 Life Points to declare an attack with this monster.If \"Toon World\" on the field is destroyed, destroy this card.This card can attack your opponent directly, unless they control a Toon Monster.If they do control one, this card must target a Toon Monster for its attacks.";
        }
    }
}
