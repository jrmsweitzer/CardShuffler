using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Relinquished : RitualMonster
    {
        public Relinquished(YugiohGame game) : base(game)
        {
            Name = "Relinquished";
            RitualSpellCardName = "Black Illusion Ritual";
            SetCodes.Add("SS01-ENC08");
            SetCodes.Add("STP1-EN010");
            Attribute = MonsterAttribute.Dark;
            Type = MonsterType.Spellcaster;
            ATK = 0;
            DEF = 0;
            CardCode = 64631466;
            Description = "You can Ritual Summon this card with \"Black Illusion Ritual\". Once per turn: You can target 1 monster your opponent controls; equip that target to this card. (max. 1). This card's ATK/DEF become equal to that equipped monster's. If this card would be destroyed by battle, destroy that equipped monster instead. While equipped with that monster, any battle damage you take from battles involving this card inflicts equal effect damage to your opponent.";
            EnableReviveLimit();

            // Equip monster
            Effects.Add(new Effect()
            {
                Category = EffectCategory.Equip,
                Types = new List<EffectType>
                {
                    EffectType.Igntion
                },
                Property = EffectProperty.CardTarget,
                Range = EffectRange.MZone,
                CountLimit = 1,
                Condition = EquipCondition(),
                Targets = GetEquipTargets(),
                Operation = EquipOperation()
            });

            // Set attack
            Effects.Add(new Effect()
            {
                Types = new List<EffectType>
                {
                    EffectType.Single
                },
                Property = EffectProperty.SingleRange,
                Range = EffectRange.MZone,
                Code = EffectCode.Effect_SetAttack,
                Condition = AtkDefCondition(),
                Value = GetAttackValue()
            });

            // Set defense
            Effects.Add(new Effect()
            {
                Types = new List<EffectType>
                {
                    EffectType.Single
                },
                Property = EffectProperty.SingleRange,
                Range = EffectRange.MZone,
                Code = EffectCode.Effect_SetDefense,
                Condition = AtkDefCondition(),
                Value = GetDefenseValue()
            });

            // Both players take damage while equipped
            Effects.Add(new Effect()
            {
                Types = new List<EffectType>
                {
                    EffectType.Field,
                    EffectType.Continuous
                },
                Code = EffectCode.Event_BattleDamage,
                Range = EffectRange.MZone,
                Condition = DamageCondition(),
                Operation = DamageOperation()
            });
        }

        private bool _hasMonsterEquipped = false;

        private bool EquipCondition()
        {
            if (_hasMonsterEquipped)
                return false;
            if (Owner != TurnPlayer)
                return false;
            if (((YugiohGamePlayer)Owner).Field.HasFreeSpellTrapZone() == false)
                return false;
            return true;
        }

        private bool AtkDefCondition()
        {
            return true;
        }

        private bool DamageCondition()
        {
            return true;
        }

        private List<YugiohGameCard> GetEquipTargets()
        {
            return new List<YugiohGameCard>();
        }

        private Action EquipOperation()
        {
            return () =>
            {

            };
        }
        private Action DamageOperation()
        {
            return () =>
            {

            };
        }

        private int GetAttackValue()
        {
            return 0;
        }

        private int GetDefenseValue()
        {
            return 0;
        }
    }
}
