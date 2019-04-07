using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BlueEyesWhiteDragon : NormalMonster
    {
        public BlueEyesWhiteDragon(YugiohGame game) : base(game)
        {
            Name = "Blue-Eyes White Dragon";
            Attribute = MonsterAttribute.Light;
            Level = 8;
            Type = MonsterType.Dragon;
            ATK = 3000;
            DEF = 2500;
            SetCodes.Add("SS02-ENA01");
            CardCode = 89631139;
            Description = "This legendary dragon is a powerful engine of destruction. Virtually invincible, very few have faced this awesome creature and lived to tell the tale.";
        }
    }
}
