using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersOracle : EffectMonster
    {
        public GravekeepersOracle(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Oracle";
            Attribute = MonsterAttribute.Dark;
            Level = 10;
            Type = MonsterType.Spellcaster;
            ATK = 2000;
            DEF = 1500;
            SetCodes.Add("SS01-ENB10");
            CardCode = 25524823;
            Description = "You can Tribute 3 monsters or 1 \"Gravekeeper's\" monster to Tribute Summon (but not Set) this card. When this card is Tribute Summoned: You can activate any of these effects, and resolve in sequence, up to the number of \"Gravekeeper's\" monsters Tributed for its Summon;\n" +
"● This card gains ATK equal to the combined Levels that all monsters Tributed for its Tribute Summon had on the field x 100.\n" +
"● Destroy all Set monsters your opponent controls.\n" +
"● All monsters your opponent currently controls lose 2000 ATK and DEF.";
        }
    }
}
