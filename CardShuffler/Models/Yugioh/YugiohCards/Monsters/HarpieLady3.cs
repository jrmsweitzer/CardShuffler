using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards.Monsters
{
    public class HarpieLady3 : EffectMonster
    {
        public HarpieLady3(YugiohGame game) : base(game)
        {
            Name = "Harpie Lady 23;
            Attribute = MonsterAttribute.Wind;
            Level = 4;
            Type = MonsterType.WingedBeast;
            ATK = 1300;
            DEF = 1400;
            SetCodes.Add("SS02-ENC03");
            CardCode = 54415063;
        }
    }
}
