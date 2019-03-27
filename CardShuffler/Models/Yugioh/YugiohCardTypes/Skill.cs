using System;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public class Skill: YugiohGameCard
    {
        public Skill(YugiohGame game) : base(game)
        {
        }
        public string ActiveSideText { get; set; }
        public string HiddenSidetText { get; set; }
        public string Character { get; set; }
        public int SkillCount;
        public bool CanActivateFirstSkill;
        public bool CanActivateSecondSkill;
        public bool ExecuteFirstSkill;
        public bool ExecuteSecondSkill;
        public List<Card> GetLegalTargetsForFirstSkill;
        public List<Card> GetLegalTargetsForSecondSkill;
    }
}
