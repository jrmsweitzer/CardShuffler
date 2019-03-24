using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class GearfriedtheIronKnight : EffectMonster
    {
        public GearfriedtheIronKnight(YugiohGame game) : base(game)
        {
            Name = "Gearfried the Iron Knight";
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Warrior;
            ATK = 1800;
            DEF = 1600;
            SetCodes.Add("SS02-ENB10");
            CardCode = 00423705;
        }
    }
}
