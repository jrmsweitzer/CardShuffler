using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class LordofD : EffectMonster
    {
        public TypeTargetProtection DragonProtection = new TypeTargetProtection()
        {
            ProtectedType = MonsterType.Dragon,
            ProtectedFromTargetingMonsterEffects = true,
            ProtectedFromTargetingSpells = true,
            ProtectedFromTargetingTraps = true
        };

        public LordofD(YugiohGame game) : base(game)
        {
            Name = "Lord of D.";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Spellcaster;
            EffectText = "Neither player can target monsters on the field with effects.";
            ATK = 1200;
            DEF = 1100;
            OnFieldEnter = () =>
            {
                TurnPlayer.Field.FieldProtections.Add(DragonProtection);
            };
            OnFieldLeave = () =>
            {
                TurnPlayer.Field.FieldProtections.Remove(DragonProtection);
            };
        }
    }
}
