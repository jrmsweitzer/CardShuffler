using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh
{
    public class YugiohFieldProtection
    {
    }

    public class TypeTargetProtection : YugiohFieldProtection
    {
        public MonsterType ProtectedType { get; set; }
        public bool ProtectedFromAllSpells { get; set; } = false;
        public bool ProtectedFromTargetingSpells { get; set; } = false;
        public bool ProtectedFromAllTraps { get; set; } = false;
        public bool ProtectedFromTargetingTraps { get; set; } = false;
        public bool ProtectedFromAllMonsterEffects { get; set; } = false;
        public bool ProtectedFromTargetingMonsterEffects { get; set; } = false;
    }
}
