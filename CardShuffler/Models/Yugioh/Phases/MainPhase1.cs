using CardShuffler.Models.Yugioh.YugiohCardTypes;
using CardShuffler.Models.Yugioh.Zones;
using System;
using System.Linq;

namespace CardShuffler.Models.Yugioh.Phases
{
    public class MainPhase1
    {
        public MainPhase1(YugiohGame game)
        {
            _game = game;
        }

        private YugiohGame _game;
        
        private bool _haveAlreadyNormalSummoned { get; set; } = false;

        public void Execute(YugiohGamePlayer player, YugiohGame game)
        {
            Console.WriteLine($"{player.Name} entered Main Phase 1");

            var hasFreeZone = player.Field.HasFreeMonsterZone();
            var normalSummonableMonsters = player.Hand.GetMonstersThatCanBeNormalSummoned();

            if (hasFreeZone && normalSummonableMonsters.Any())
            {
                var monsterToSummon = (Monster)normalSummonableMonsters[0];
                NormalSummonWithoutTribute(monsterToSummon);
            }
        }

        public bool ActivateSpell(Spell spell, params object[] targets)
        {
            if (spell.CanActivate())
            {
                if (spell.Activate(targets))
                    return spell.Resolve(targets);
                else
                    return false;
            }
            else
                return false;
        }

        private void SummonComplete(Monster monster, bool faceup, bool attackPosition)
        {
            if (faceup)
            {
                if (attackPosition)
                    monster.Position = CardPosition.FaceUpAttack;
                else
                    monster.Position = CardPosition.FaceUpDefense;
            }
            else
            {
                if (attackPosition)
                    monster.Position = CardPosition.FaceDownAttack;
                else
                    monster.Position = CardPosition.FaceDownDefense;
            }
            monster.Location = CardLocation.MonsterZone;
            if (monster is EffectMonster effectMonster)
            {
                effectMonster.OnFieldEnter?.Invoke();
            }
            _game.TurnPlayer.LastSuccessfulNormalSummon = monster;
        }

        public bool NormalSummonWithoutTribute(Monster monster)
        {
            if (_haveAlreadyNormalSummoned) return false;
            if (monster.Level >= 5)
            {
                Console.WriteLine($"Cannot Normal Summon a level 5 or higher without tributes.");
                return false;
            }
            else
            {
                var player = (YugiohGamePlayer)_game.TurnPlayer;
                if (player.Field.GetMonsters().Count == 3)
                {
                    Console.WriteLine($"We do not have enough space to normal summon {monster.Name}");
                    return false;
                }
                else
                {
                    player.Hand.Cards.Remove(monster);
                    player.Field.NormalSummon(monster);
                    _haveAlreadyNormalSummoned = true;
                    SummonComplete(monster, true, true);
                    Console.WriteLine($"{player.Name} Normal Summoned {monster.Name}.");
                    return true;
                }
            }
        }

        public bool NormalSetWithoutTribute(Monster monster)
        {
            if (_haveAlreadyNormalSummoned) return false;
            if (monster.Level >= 5)
            {
                Console.WriteLine($"Cannot Normal Set a level 5 or higher without tributes.");
                return false;
            }
            else
            {
                var player = (YugiohGamePlayer)_game.TurnPlayer;
                if (player.Field.GetMonsters().Count == 3)
                {
                    Console.WriteLine($"We do not have enough space to normal set {monster.Name}");
                    return false;
                }
                else
                {
                    player.Hand.Cards.Remove(monster);
                    player.Field.NormalSet(monster);
                    SummonComplete(monster, false, false);
                    Console.WriteLine($"{player.Name} Normal Set {monster.Name}.");
                    _haveAlreadyNormalSummoned = true;
                    return true;
                }
            }
        }

        public bool TributeSummon(Monster monster)
        {
            if (_haveAlreadyNormalSummoned) return false;
            if (monster.Level <= 4) return false;
            var player = (YugiohGamePlayer)_game.TurnPlayer;
            if (monster.Level == 5 || monster.Level == 6)
            {
                if (player.Field.GetMonsters().Count == 1)
                {
                    var tributeMaterial = player.Field.GetMonsters()[0];
                    return TributeSummon(monster, tributeMaterial);
                }
                else
                    return false;
            }
            else
            {
                if (player.Field.GetMonsters().Count == 2)
                {
                    var tributeMaterial1 = player.Field.GetMonsters()[0];
                    var tributeMaterial2 = player.Field.GetMonsters()[1];
                    return TributeSummon(monster, tributeMaterial1, tributeMaterial2);
                }
                else
                    return false;
            }
        }

        public bool TributeSet(Monster monster)
        {
            if (_haveAlreadyNormalSummoned) return false;
            if (monster.Level <= 4) return false;
            var player = (YugiohGamePlayer)_game.TurnPlayer;
            if (monster.Level == 5 || monster.Level == 6)
            {
                if (player.Field.GetMonsters().Count == 1)
                {
                    var tributeMaterial = player.Field.GetMonsters()[0];
                    return TributeSet(monster, tributeMaterial);
                }
                else
                    return false;
            }
            else
            {
                if (player.Field.GetMonsters().Count == 2)
                {
                    var tributeMaterial1 = player.Field.GetMonsters()[0];
                    var tributeMaterial2 = player.Field.GetMonsters()[1];
                    return TributeSet(monster, tributeMaterial1, tributeMaterial2);
                }
                else
                    return false;
            }
        }

        public bool TributeSummon(Monster monster, Monster tributeMaterial)
        {
            if (_haveAlreadyNormalSummoned) return false;
            if (monster.Level <= 4) return false;
            else if (monster.Level >= 7) return false;

            var player = (YugiohGamePlayer)_game.TurnPlayer;
            player.DiscardPile.Add(tributeMaterial);
            tributeMaterial.Location = CardLocation.Graveyard;
            player.Hand.Cards.Remove(monster);
            var zone = player.Field.MonsterZones.First(z => z.Monster == tributeMaterial);
            zone.Monster = monster;
            SummonComplete(monster, true, true);
            Console.WriteLine($"{player.Name} Tribute Summoned {monster.Name} by tributing {tributeMaterial.Name}.");
            _haveAlreadyNormalSummoned = true;
            return true;
        }

        public bool TributeSet(Monster monster, Monster tributeMaterial)
        {
            if (_haveAlreadyNormalSummoned) return false;
            if (monster.Level <= 4) return false;
            else if (monster.Level >= 7) return false;

            var player = (YugiohGamePlayer)_game.TurnPlayer;
            player.DiscardPile.Add(tributeMaterial);
            tributeMaterial.Location = CardLocation.Graveyard;
            player.Hand.Cards.Remove(monster);
            var zone = player.Field.MonsterZones.First(z => z.Monster == tributeMaterial);
            zone.Monster = monster;
            SummonComplete(monster, false, false);
            Console.WriteLine($"{player.Name} Tribute Set {monster.Name} by tributing {tributeMaterial.Name}.");
            _haveAlreadyNormalSummoned = true;
            return true;
        }

        public bool TributeSummon(Monster monster, Monster tributeMaterial1, Monster tributeMaterial2)
        {
            if (_haveAlreadyNormalSummoned) return false;
            if (monster.Level <= 6) return false;

            var player = (YugiohGamePlayer)_game.TurnPlayer;
            player.DiscardPile.Add(tributeMaterial1);
            tributeMaterial1.Location = CardLocation.Graveyard;
            player.DiscardPile.Add(tributeMaterial2);
            tributeMaterial2.Location = CardLocation.Graveyard;
            player.Hand.Cards.Remove(monster);
            var zone1 = player.Field.MonsterZones.First(z => z.Monster == tributeMaterial1);
            zone1.Monster = monster;
            var zIndex = player.Field.MonsterZones.ToList().FindIndex(z => z.Monster == tributeMaterial2);
            player.Field.MonsterZones[zIndex] = new MonsterZone();
            SummonComplete(monster, true, true);
            Console.WriteLine($"{player.Name} Tribute Summoned {monster.Name} by tributing {tributeMaterial1.Name} and {tributeMaterial2.Name}.");
            _haveAlreadyNormalSummoned = true;
            return true;
        }

        public bool TributeSet(Monster monster, Monster tributeMaterial1, Monster tributeMaterial2)
        {
            if (_haveAlreadyNormalSummoned) return false;
            if (monster.Level <= 6) return false;

            var player = (YugiohGamePlayer)_game.TurnPlayer;
            player.DiscardPile.Add(tributeMaterial1);
            tributeMaterial1.Location = CardLocation.Graveyard;
            player.DiscardPile.Add(tributeMaterial2);
            tributeMaterial2.Location = CardLocation.Graveyard;
            player.Hand.Cards.Remove(monster);
            var zone1 = player.Field.MonsterZones.First(z => z.Monster == tributeMaterial1);
            zone1.Monster = monster;
            var zIndex = player.Field.MonsterZones.ToList().FindIndex(z => z.Monster == tributeMaterial2);
            player.Field.MonsterZones[zIndex] = new MonsterZone();
            SummonComplete(monster, false, false);
            Console.WriteLine($"{player.Name} Tribute Set {monster.Name} by tributing {tributeMaterial1.Name} and {tributeMaterial2.Name}.");
            _haveAlreadyNormalSummoned = true;
            return true;
        }

        public bool SetTrap(Trap trap)
        {
            var player = (YugiohGamePlayer)_game.TurnPlayer;
            if (player.Field.HasFreeSpellTrapZone() == false)
                return false;

            trap.TurnSet = _game.Turn;
            player.Hand.Cards.Remove(trap);

            var zone = player.Field.SpellTrapZones.FirstOrDefault(z => z.SpellTrapCard == null);
            zone.IsFaceup = false;
            zone.SpellTrapCard = trap;
            trap.Location = CardLocation.FieldSpellZone;
            trap.Position = CardPosition.FaceDown;
            return true;
        }

        public bool SetSpell(Spell spell)
        {
            var player = (YugiohGamePlayer)_game.TurnPlayer;
            if (player.Field.HasFreeSpellTrapZone() == false)
                return false;

            if (spell is QuickplaySpell qpSpell)
                qpSpell.TurnSet = _game.Turn;
            player.Hand.Cards.Remove(spell);

            var zone = player.Field.SpellTrapZones.FirstOrDefault(z => z.SpellTrapCard == null);
            zone.IsFaceup = false;
            zone.SpellTrapCard = spell;
            spell.Location = CardLocation.FieldSpellZone;
            spell.Position = CardPosition.FaceDown;
            return true;
        }
    }
}
