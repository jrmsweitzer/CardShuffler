using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
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

            CanActivateIgnitionEffect =
                Owner == TurnPlayer &&
                Location == CardLocation.MonsterZone &&
                IsRevealed == true;

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
