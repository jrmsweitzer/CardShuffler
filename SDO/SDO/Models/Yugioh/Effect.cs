using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh
{
    public class Effect
    {
        public EffectCategory Category { get; set; } = EffectCategory.None;
        public List<EffectType> Types { get; set; } = new List<EffectType>();
        public EffectProperty Property { get; set; }
        public EffectRange Range { get; set; }
        public int CountLimit { get; set; }
        public bool Condition { get; set; }
        public List<YugiohGameCard> Targets { get; set; } = new List<YugiohGameCard>();
        public Action Operation { get; set; }
        public EffectCode Code { get; set; }
        public object Value { get; set; }
        public int Cost { get; set; }
    }

    public enum EffectCategory
    {
        None,
        Equip,
        Draw
    }

    public enum EffectType
    {
        Igntion,
        Single,
        Field,
        Continuous,
        Trigger_F
    }

    public enum EffectProperty
    {
        CardTarget,
        SingleRange,
        PlayerTarget,
        Uncopyable
    }

    public enum EffectRange
    {
        MZone,
        Hand
    }

    public enum EffectCode
    {
        Effect_AttackCost,
        Effect_CannotAttackDirect,
        Effect_CannotSelectBattleTarget,
        Effect_DirectAttack,
        Effect_SetAttack,
        Effect_SetDefense,
        Effect_SpecialSummonProcedure,

        Event_BattleDamage,
        Event_FlipSummonSuccess,
        Event_LeaveField,
        Event_SummonSuccess,
        Event_SpecialSummonSuccess,
    }
}
