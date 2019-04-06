using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LegiontheFiendJester : EffectMonster
    {
        public LegiontheFiendJester(YugiohGame game) : base(game)
        {
            Name = "Legion the Fiend Jester";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1300;
            DEF = 1500;
            SetCodes.Add("SS01-ENA05");
            CardCode = 25280974;
            Description = "During your Main Phase, you can Tribute Summon 1 Spellcaster-Type monster in face-up Attack Position, in addition to your Normal Summon/Set. (You can only gain this effect once per turn.) If this card is sent from the field to the GY: You can add 1 Spellcaster-Type Normal Monster from your Deck or GY to your hand. You can only use this effect of \"Legion the Fiend Jester\" once per turn.";
        }
    }
}
