using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class Copycat : EffectMonster
    {
        public Copycat(YugiohGame game) : base(game)
        {
            Name = "Copycat";
            Attribute = MonsterAttribute.Light;
            Level = 1;
            Type = MonsterType.Spellcaster;
            ATK = 0;
            DEF = 0;
            SetCodes.Add("SS02-ENB09");
            CardCode = 26376390;
        }
    }
}
