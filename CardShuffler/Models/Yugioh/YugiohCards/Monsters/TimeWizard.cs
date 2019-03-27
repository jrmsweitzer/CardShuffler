using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;

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
            SetCodes.Add("SS02-ENB07");
            CardCode = 71625222;

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
