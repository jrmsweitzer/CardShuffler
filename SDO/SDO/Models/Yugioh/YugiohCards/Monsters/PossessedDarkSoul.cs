using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class PossessedDarkSoul : EffectMonster
    {
        public PossessedDarkSoul(YugiohGame game) : base(game)
        {
            Name = "Possessed Dark Soul";
            SetCodes.Add("SBLS-EN003");
            Attribute = MonsterAttribute.Dark;
            Level = 3;
            Type = MonsterType.Fiend;
            ATK = 1200;
            DEF = 800;
            CardCode = 52860176;
            Description = "You can Tribute this face-up card; take control of all face-up Level 3 or lower monsters your opponent currently controls.";
        }
    }
}
