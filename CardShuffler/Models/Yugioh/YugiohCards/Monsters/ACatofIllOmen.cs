using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ACatofIllOmen : EffectMonster
    {
        public ACatofIllOmen(YugiohGame game) : base(game)
        {
            Name = "A Cat of Ill Omen";
            Attribute = MonsterAttribute.Dark;
            Level = 2;
            Type = MonsterType.Beast;
            ATK = 500;
            DEF = 300;
            CardCode = 24140059;
            SetCodes.Add("SS01-ENB11");

            HasFlipEffect = true;
            FlipEffect = () =>
            {
                throw new NotImplementedException("A cat of ill omen flip effect");
            };
        }
    }
}
