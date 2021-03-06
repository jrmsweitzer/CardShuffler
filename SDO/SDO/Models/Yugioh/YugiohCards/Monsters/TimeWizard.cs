﻿using SDO.Models.Yugioh.YugiohCardTypes;
using System;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TimeWizard : EffectMonster
    {
        public TimeWizard(YugiohGame game) : base(game)
        {
            Name = "Time Wizard";
            Attribute = MonsterAttribute.Light;
            Level = 2;
            Type = MonsterType.Spellcaster;
            ATK = 500;
            DEF = 400;
            SetCodes.Add("SS02-ENB07");
            SetCodes.Add("STP1-EN008");
            CardCode = 71625222;
            Description = "Once per turn: You can toss a coin and call it. If you call it right, destroy all monsters your opponent controls. If you call it wrong, destroy as many monsters you control as possible, and if you do, take damage equal to half the total ATK those destroyed monsters had while face-up on the field.";

            CanActivateIgnitionEffect =
                Owner == TurnPlayer &&
                Location == CardLocation.MonsterZone &&
               (Position == CardPosition.FaceUpAttack || Position == CardPosition.FaceUpDefense);

            IgnitionEffect = () =>
            {
                var random = new Random();
                bool heads = random.Next(0, 1) == 1;
                if (heads)
                {
                    foreach (Monster monster in DefendingPlayer.Field.GetMonsters())
                    {
                        DefendingPlayer.Field.SendMonsterToGrave(monster, DefendingPlayer);
                    }
                }
                else
                {
                    var combinedATK = 0;
                    foreach (Monster monster in TurnPlayer.Field.GetMonsters())
                    {
                        combinedATK += monster.ATK;
                        TurnPlayer.Field.SendMonsterToGrave(monster, TurnPlayer);
                    }
                }
            };
        }
    }
}
