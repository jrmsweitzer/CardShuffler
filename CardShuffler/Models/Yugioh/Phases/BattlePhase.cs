using CardShuffler.Models.Yugioh.YugiohCardTypes;
using CardShuffler.Models.Yugioh.Zones;
using System;
using System.Linq;

namespace CardShuffler.Models.Yugioh.Phases
{
    public class BattlePhase
    {
        public void Execute(YugiohGamePlayer player, YugiohGamePlayer opponent)
        {
            try
            {
                Console.WriteLine($"{player.Name} entered Battle Phase");

                //var atkPosMonsters = player.Field.GetMonstersInAttackPosition();
                //foreach (var monster in atkPosMonsters)
                //{
                //    if (opponent.Field.GetMonsters().Count() == 0)
                //    {
                //        AttackDirectly(player, monster, opponent);
                //        continue;
                //    }

                //    var target = SelectTargetToAttack(monster, opponent);

                //    // There's nothing I can attack, everything is too big!
                //    if (target == null) continue;

                //    Attack(player, monster, opponent, target);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Monster SelectTargetToAttack(Monster monster, YugiohGamePlayer opponent)
        {
            try
            {
                var offense = monster.ATK;
                var monstersInAtkPos = opponent.Field.GetMonstersInAttackPosition();
                if (monstersInAtkPos.Any())
                {
                    var smallerMonsters = monstersInAtkPos
                            .Where(m => m.ATK < offense);
                    if (smallerMonsters.Any())
                    { 
                        var biggestOffenseOppMonster = smallerMonsters
                            .OrderBy(m => m.ATK)
                            .First();
                        if (biggestOffenseOppMonster != null)
                            return biggestOffenseOppMonster;
                    }
                }

                var monstersInDefPos = opponent.Field.GetMonstersInDefensePosition();
                if (monstersInDefPos.Any())
                {
                    var smallerMonsters = monstersInDefPos
                           .Where(m => m.DEF < offense);
                    if (smallerMonsters.Any())
                    {
                        var biggestDefenseOppMonster = smallerMonsters
                               .OrderBy(m => m.DEF)
                               .First();
                        if (biggestDefenseOppMonster != null)
                            return biggestDefenseOppMonster;
                    }
                }
                
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AttackDirectly(YugiohGamePlayer player, Monster monster,
                            YugiohGamePlayer opponent)
        {
            Console.WriteLine($"{monster.Name} attacks directly!");
            opponent.LifePoints -= monster.ATK;
            Console.WriteLine($"{opponent.Name} takes {monster.ATK} damage!");
        }

        public void Attack(YugiohGamePlayer player, Monster playerMonster, 
                            YugiohGamePlayer opponent, Monster opponentMonster)
        {
            try
            {
                var pZoneIndex = player.Field.MonsterZones.ToList().FindIndex(m => m.Monster == playerMonster);
                var pZone = player.Field.MonsterZones[pZoneIndex];

                var oZoneIndex = opponent.Field.MonsterZones.ToList().FindIndex(m => m.Monster == opponentMonster);
                var oZone = opponent.Field.MonsterZones[oZoneIndex];

                var isOpposingMonsterInAttack = oZone.Monster.Position == CardPosition.FaceUpAttack;
                var difference = pZone.Monster.ATK - (isOpposingMonsterInAttack ?
                        oZone.Monster.ATK :
                        oZone.Monster.DEF);

                var offense = pZone.Monster.ATK;
                if (isOpposingMonsterInAttack)
                {
                    var opposingAtk = oZone.Monster.ATK;
                    if (offense < opposingAtk)
                    {
                        // player loses
                        Console.WriteLine($"{pZone.Monster.Name} was destroyed in battle by {oZone.Monster.Name}");
                        Console.WriteLine($"{player.Name} lost {(-1 * difference)} LP");
                        player.DiscardPile.Add(pZone.Monster);
                        pZone.Monster.Location = CardLocation.Graveyard;
                        player.Field.MonsterZones[pZoneIndex] = new MonsterZone();
                        player.LifePoints += difference;
                    }
                    else if (offense == opposingAtk)
                    {
                        // tie, they both lose
                        Console.WriteLine($"{pZone.Monster.Name} and {oZone.Monster.Name} destroyed each other in battle");
                        player.DiscardPile.Add(pZone.Monster);
                        pZone.Monster.Location = CardLocation.Graveyard;
                        player.Field.MonsterZones[pZoneIndex] = new MonsterZone();
                        opponent.DiscardPile.Add(oZone.Monster);
                        oZone.Monster.Location = CardLocation.Graveyard;
                        opponent.Field.MonsterZones[oZoneIndex] = new MonsterZone();
                    }
                    else
                    {
                        // player wins
                        Console.WriteLine($"{oZone.Monster.Name} was destroyed in battle by {pZone.Monster.Name}");
                        opponent.DiscardPile.Add(oZone.Monster);
                        oZone.Monster.Location = CardLocation.Graveyard;
                        opponent.Field.MonsterZones[oZoneIndex] = new MonsterZone();
                        opponent.LifePoints -= difference;
                        Console.WriteLine($"{opponent.Name} lost {difference} LP");
                    }
                }
                else
                {
                    if (oZone.Monster.Position == CardPosition.FaceDownDefense)
                    {
                        oZone.Monster.Position = CardPosition.FaceUpDefense;
                        if (oZone.Monster is EffectMonster effectMonster &&
                                effectMonster.HasFlipEffect)
                        {
                            effectMonster.FlipEffect.Invoke();
                        }
                    }
                    // opposing monster in defense
                    var opposingDef = oZone.Monster.DEF;
                    if (offense < opposingDef)
                    {
                        Console.WriteLine($"{pZone.Monster.Name} could not destroy {oZone.Monster.Name} in this battle");
                        Console.WriteLine($"{player.Name} lost {(-1 * difference)} LP");
                        player.LifePoints += difference;
                    }
                    else if (offense == opposingDef)
                    {
                        Console.WriteLine($"{pZone.Monster.Name} could not destroy {oZone.Monster.Name} in this battle");
                    }
                    else
                    {
                        Console.WriteLine($"{oZone.Monster.Name} was destroyed in battle by {pZone.Monster.Name}");
                        opponent.DiscardPile.Add(oZone.Monster);
                        oZone.Monster.Location = CardLocation.Graveyard;
                        opponent.Field.MonsterZones[oZoneIndex] = new MonsterZone();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
