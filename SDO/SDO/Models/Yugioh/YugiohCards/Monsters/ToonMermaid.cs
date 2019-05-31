using System;
using System.Collections.Generic;
using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ToonMermaid : EffectMonster
    {
        public ToonMermaid(YugiohGame game) : base(game)
        {
            Name = "Toon Mermaid";
            Attribute = MonsterAttribute.Water;
            Level = 4;
            Type = MonsterType.Aqua;
            ATK = 1400;
            DEF = 1500;
            SetCodes.Add("SS01-ENC06");
            CardCode = 65458948;
            Description = "Cannot be Normal Summoned/Set. Cannot be Special Summoned unless you control a face-up \"Toon World\". Must first be Special Summoned (from your hand) by Tributing the same number of monsters needed for a Tribute Summon (normally 0). This card cannot attack the turn it is Special Summoned. You must pay 500 Life Points to declare an attack with this monster. If \"Toon World\" on the field is destroyed, destroy this card. This card can attack your opponent directly, unless they control a Toon Monster. If they do control one, this card must target a Toon Monster for its attacks.";
            EnableReviveLimit();

            Effects.Add(GetSpecialSummonRuleEffect());
            Effects.Add(GetDestroyWhenToonWorldLeavesFieldEffect());
            Effects.Add(GetDirectAttackEffect());
            Effects.Add(GetCannotSelectBattleTargetEffect());
            Effects.Add(GetCannotAttackDirectlyEffect());
            Effects.Add(GetCannotAttackOnSpecialSummonEffect());
            Effects.Add(GetAttackCostEffect());
        }

        /// <summary>
        /// Effects
        /// </summary>=
        private Effect GetSpecialSummonRuleEffect()
        {
            return new Effect()
            {
                Types = new List<EffectType>()
                {
                    EffectType.Field
                },
                Code = EffectCode.Effect_SpecialSummonProcedure,
                Property = EffectProperty.Uncopyable,
                Range = EffectRange.Hand,
                Condition = GetSpecialSummonCondition(),
            };
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

        private Effect GetCannotSelectBattleTargetEffect()
        {
            return new Effect()
            {
                Types = new List<EffectType>()
                {
                    EffectType.Single,
                },
                Code = EffectCode.Effect_CannotSelectBattleTarget,
                Condition = GetAttackCondition(),
                Value = GetAtkLimit()
            };
        }

        private Effect GetCannotAttackDirectlyEffect()
        {
            return new Effect()
            {
                Types = new List<EffectType>()
                {
                    EffectType.Single,
                },
                Code = EffectCode.Effect_CannotAttackDirect,
                Condition = GetAttackCondition()
            };
        }
        private Effect GetCannotAttackOnSpecialSummonEffect()
        {
            return new Effect()
            {
                Types = new List<EffectType>()
                {
                    EffectType.Single,
                    EffectType.Continuous
                },
                Code = EffectCode.Event_SpecialSummonSuccess,
                Operation = GetCannotAttackThisTurnOperation(),
            };
        }
        private Effect GetAttackCostEffect()
        {
            return new Effect()
            {
                Types = new List<EffectType>()
                {
                    EffectType.Single,
                },
                Code = EffectCode.Effect_AttackCost,
                Cost = GetAttackCost(),
                Operation = GetAttackOperation()
            };
        }

        /// <summary>
        /// Operations
        /// </summary>
        private Action GetSpecialSummonOperation()
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
        private Action GetCannotAttackThisTurnOperation()
        {
            return new Action(() =>
            {

            });
        }
        private Action GetAttackOperation()
        {
            return new Action(() =>
            {
                
            });
        }

        /// <summary>
        /// Conditions
        /// </summary>
        private bool GetSpecialSummonCondition()
        {
            return true;
        }

        private bool GetSelfDestroyCondition()
        {
            return false;
        }

        private bool GetDirectAttackCondition()
        {
            return true;
        }

        private bool GetAttackCondition()
        {
            return true;
        }

        private int GetAttackCost()
        {
            return 500;
        }

        private bool GetAtkLimit()
        {
            return true;
        }
    }
}
