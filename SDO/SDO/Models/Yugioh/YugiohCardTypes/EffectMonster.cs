using SDO.Models.Yugioh.YugiohCards;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class EffectMonster: Monster
    {
        public Action OnFieldEnter;
        public Action OnFieldLeave;
        public Action IgnitionEffect;
        public Action FlipEffect;

        public bool CanBeNormalSummoned { get; set; } = true;
        public bool CanBeSpecialSummoned { get; set; } = true;
        public bool CanActivateIgnitionEffect { get; set; } = false;
        public bool HasFlipEffect { get; set; } = false;
        public bool MustFirstBeSpecialSummoned { get; set; } = false;
        public override string ToString()
        {
            return $"{Name} {Attribute.ToString().ToUpper()} {Level} {Type}/Effect {ATK}/{DEF}";
        }
        public string EffectText { get; set; }

        public EffectMonster(YugiohGame game) : base(game)
        {
        }
        public EffectMonster Clone()
        {
            return new EffectMonster(Game)
            {
                ATK = ATK,
                Attribute = Attribute,
                CanBeNormalSummoned = CanBeNormalSummoned,
                CanBeSpecialSummoned = CanBeSpecialSummoned,
                DEF = DEF,
                EffectText = EffectText,
                Level = Level,
                Location = Location,
                MustFirstBeSpecialSummoned = MustFirstBeSpecialSummoned,
                Name = Name,
                Type = Type,
                OnFieldEnter = OnFieldEnter,
                OnFieldLeave = OnFieldLeave
            };
        }
    }
}
