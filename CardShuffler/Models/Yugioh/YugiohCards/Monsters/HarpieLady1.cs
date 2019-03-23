using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class HarpieLady1: EffectMonster
    {
        YugiohFieldAttributeBuff WindBoost = new YugiohFieldAttributeBuff()
        {
            AffectedAttribute = MonsterAttribute.Wind,
            ATKBuff = 300,
        };

        public HarpieLady1(YugiohGame game): base(game)
        {
            Name = "Harpie Lady 1";
            Attribute = MonsterAttribute.Wind;
            Type = MonsterType.WingedBeast;
            ATK = 1300;
            DEF = 1400;
            Level = 4;
            EffectText = "(This card's name is always treated as \"Harpie Lady\".) All WIND monsters gain 300 ATK.";

            OnFieldEnter = () =>
            {
                Game.FieldBuffs.Add(WindBoost);
            };

            OnFieldLeave = () =>
            {
                Game.FieldBuffs.Remove(WindBoost);
            };
        }

        
        
    }
}
