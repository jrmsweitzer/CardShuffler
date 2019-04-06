using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ToonAlligator : NormalMonster
    {
        public ToonAlligator(YugiohGame game) : base(game)
        {
            Name = "Toon Alligator";
            Attribute = MonsterAttribute.Water;
            Level = 4;
            Type = MonsterType.Reptile;
            ATK = 800;
            DEF = 1600;
            SetCodes.Add("SS01-ENC02");
            CardCode = 59383041;
            Description = "An alligator monster straight from the cartoons.";
        }
    }
}
