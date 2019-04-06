using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class Skill: YugiohGameCard
    {
        public Skill(YugiohGame game) : base(game)
        {
        }
        public string SkillActivationDescription { get; set; } = "Flip this card over when you activate this Skill.";
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
