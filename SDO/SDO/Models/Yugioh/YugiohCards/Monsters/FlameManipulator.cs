using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class FlameManipulator : NormalMonster
    {
        public FlameManipulator(YugiohGame game) : base(game)
        {
            Name = "Flame Manipulator";
            Attribute = MonsterAttribute.Fire;
            Level = 3;
            Type = MonsterType.Spellcaster;
            ATK = 900;
            DEF = 1000;
            CardCode = 34460851;
            SetCodes.Add("SS02-ENB03");
        }
    }
}
