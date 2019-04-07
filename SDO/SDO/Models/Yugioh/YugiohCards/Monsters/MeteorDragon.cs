using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MeteorDragon : NormalMonster
    {
        public MeteorDragon(YugiohGame game) : base(game)
        {
            Name = "Meteor Dragon";
            Attribute = MonsterAttribute.Earth;
            Level = 6;
            Type = MonsterType.Dragon;
            ATK = 1800;
            DEF = 2000;
            SetCodes.Add("SS02-ENB02");
            CardCode = 64271667;
            Description = "This dragon appeared from the sky and crashed to the earth.";
        }
    }
}
