using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ToonMaskedSorcerer : EffectMonster
    {
        public ToonMaskedSorcerer(YugiohGame game) : base(game)
        {
            Name = "Toon Masked Sorcerer";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 900;
            DEF = 1400;
            SetCodes.Add("SS01-ENC05");
            CardCode = 16392422;
            Description = "Cannot attack the turn it is Summoned. If \"Toon World\" on the field is destroyed, destroy this card. While you control \"Toon World\" and your opponent controls no Toon monsters, this card can attack your opponent directly. If this card inflicts battle damage to your opponent: Draw 1 card.";

            Effects.Add(GetCannotAttackOnNormalSummonEffect());
            Effects.Add(GetCannotAttackOnSpecialSummonEffect());
            Effects.Add(GetCannotAttackOnFlipSummonEffect());
            Effects.Add(GetDestroyWhenToonWorldLeavesFieldEffect());
            Effects.Add(GetDirectAttackEffect());
            Effects.Add(GetDrawWhenDealBattleDamageEffect());
        }
        
        private Effect GetCannotAttackOnNormalSummonEffect()
        {
            return new Effect()
            {
                Types = new List<EffectType>()
                {
                    EffectType.Single,
                    EffectType.Continuous
                },
                Code = EffectCode.Event_SummonSuccess,
                Operation = CannotAttackThisTurnOperation(),
            };
        }

        private Effect GetCannotAttackOnSpecialSummonEffect()
        {
            var effect = GetCannotAttackOnNormalSummonEffect();
            effect.Code = EffectCode.Event_SpecialSummonSuccess;
            return effect;
        }

        private Effect GetCannotAttackOnFlipSummonEffect()
        {
            var effect = GetCannotAttackOnNormalSummonEffect();
            effect.Code = EffectCode.Event_FlipSummonSuccess;
            return effect;
        }

        private Effect GetDestroyWhenToonWorldLeavesFieldEffect()
        {
            return new Effect()
            {
                Types = new List<EffectType>()
                {
                    EffectType.Field,
                    EffectType.Continuous
                },
                Range = EffectRange.MZone,
                Code = EffectCode.Event_LeaveField,
                Condition = GetSelfDestroyCondition(),
                Operation = GetSelfDestroyOperation(),
            };
        }

        private Effect GetDirectAttackEffect()
        {
            return new Effect()
            {
                Types = new List<EffectType>()
                {
                    EffectType.Single,
                },
                Code = EffectCode.Effect_DirectAttack,
                Condition = GetDirectAttackCondition()
            };
        }

        private Effect GetDrawWhenDealBattleDamageEffect()
        {
            return new Effect()
            {
                Category = EffectCategory.Draw,
                Property = EffectProperty.PlayerTarget,
                Types = new List<EffectType>()
                {
                    EffectType.Single,
                    EffectType.Trigger_F
                },
                Code = EffectCode.Event_BattleDamage,
                Condition = GetDrawCondition(),
                Targets = new List<YugiohGameCard>()
                {

                },
                Operation = GetDrawWhenDealBattleDamageOperation() 
            };
        }

        private Action CannotAttackThisTurnOperation()
        {
            return new Action(() =>
            {

            });
        }
        private Action GetSelfDestroyOperation()
        {
            return new Action(() =>
            {

            });
        }
        private Action GetDrawWhenDealBattleDamageOperation()
        {
            return new Action(() =>
            {

            });
        }

        private bool GetSelfDestroyCondition()
        {
            return false;
        }

        private bool GetDirectAttackCondition()
        {
            return true;
        }

        private bool GetDrawCondition()
        {
            return true;
        }

    }
}
