using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
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
            SetCodes.Add("SS02-ENC01");
            CardCode = 91932350;
            Description = "(This card's name is always treated as \"Harpie Lady\".) All WIND monsters gain 300 ATK.";

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
