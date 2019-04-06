using SDO.Models.Yugioh.YugiohCardTypes;
using System;

namespace SDO.Models.Yugioh.YugiohCards.Monsters
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
            Description = "FLIP: Select 1 Trap Card from your Deck and place it on top of your Deck. If \"Necrovalley\" is on the field, you can add the selected card to your hand instead.";

            HasFlipEffect = true;
            FlipEffect = () =>
            {
                throw new NotImplementedException("A cat of ill omen flip effect");
            };
        }
    }
}
