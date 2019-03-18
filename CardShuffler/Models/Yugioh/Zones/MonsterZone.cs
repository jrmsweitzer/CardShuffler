using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.Zones
{
    public class MonsterZone
    {
        public Monster Monster { get; set; } = null;
        public bool AttackPosition { get; set; }
        public bool FaceUp { get; set; }
    }
}
