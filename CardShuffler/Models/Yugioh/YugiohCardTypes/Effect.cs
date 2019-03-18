using System;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public class Effect
    {
        public string EffectText { get; set; }
        public int SpellSpeed { get; set; }
        public Action Action { get; set; }
    }
}
