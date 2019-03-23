using CardShuffler.Models.Yugioh.YugiohCardTypes;
using CardShuffler.Models.Yugioh.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardShuffler.Models.Yugioh
{
    public class YugiohField
    {
        public List<Monster> GetMonsters()
        {
            return MonsterZones.Where(zone => zone.Monster != null)
                .Select(zone => zone.Monster).ToList();
        }
        public List<Monster> GetMonstersFaceUp()
        {
            return MonsterZones.Where(zone => 
                zone.Monster != null &&
               (zone.Monster.Position == CardPosition.FaceUpAttack ||
                zone.Monster.Position == CardPosition.FaceUpDefense))
                    .Select(zone => zone.Monster).ToList();
        }
        public List<Monster> GetMonstersInAttackPosition()
        {
            return MonsterZones.Where(zone => zone.Monster != null && zone.AttackPosition == true)
                .Select(zone => zone.Monster).ToList();
        }
        public List<Monster> GetMonstersInDefensePosition()
        {
            return MonsterZones.Where(zone => zone.Monster != null && zone.AttackPosition == false)
                .Select(zone => zone.Monster).ToList();
        }
        public bool HasFreeMonsterZone()
        {
            return MonsterZones.Any(zone => zone.Monster == null);
        }
        public bool HasFreeSpellTrapZone()
        {
            return SpellTrapZones.Any(zone => zone.SpellTrapCard == null);
        }
        public void SendMonsterToGrave(Monster monster, YugiohGamePlayer player)
        {
            var index = MonsterZones.ToList().FindIndex(z => z.Monster == monster);
            MonsterZones[index] = new MonsterZone();
            player.DiscardPile.Add(monster);
            monster.Location = CardLocation.Graveyard;
        }
        public void SpecialSummonMonster(Monster monster, bool faceUp, bool atkPosition)
        {
            var zIndex = MonsterZones.ToList().FindIndex(z => z.Monster == null);
            MonsterZones[zIndex].Monster = monster;
            MonsterZones[zIndex].AttackPosition = atkPosition;
            MonsterZones[zIndex].FaceUp = faceUp;
            monster.Location = CardLocation.MonsterZone;
            if (faceUp)
            {
                if (atkPosition)
                    monster.Position = CardPosition.FaceUpAttack;
                else
                    monster.Position = CardPosition.FaceUpDefense;
            }
            else
            {
                if (atkPosition)
                    monster.Position = CardPosition.FaceDownAttack;
                else
                    monster.Position = CardPosition.FaceDownDefense;
            }            
        }
        public void PlaceSpellTrapFaceup(SpellTrap st)
        {
            var zIndex = SpellTrapZones.ToList().FindIndex(z => z.SpellTrapCard == null);
            SpellTrapZones[zIndex].SpellTrapCard = st;
            SpellTrapZones[zIndex].IsFaceup = true;
            st.Location = CardLocation.SpellTrapZone;
            st.IsRevealed = true;
        }
        public void RemoveSpellTrap(SpellTrap st)
        {
            var zIndex = SpellTrapZones.ToList().FindIndex(z => z.SpellTrapCard == st);
            SpellTrapZones[zIndex].SpellTrapCard = null;
        }
        public void PlaceSpellTrapFacedown(SpellTrap st)
        {
            var zIndex = SpellTrapZones.ToList().FindIndex(z => z.SpellTrapCard == null);
            SpellTrapZones[zIndex].SpellTrapCard = st;
            SpellTrapZones[zIndex].IsFaceup = false;
            st.Location = CardLocation.SpellTrapZone;
            st.IsRevealed = false;
        }
        public MonsterZone[] MonsterZones { get; set; } = new MonsterZone[3]
        {
            new MonsterZone(),
            new MonsterZone(),
            new MonsterZone()
        };
        public SpellTrapZone[] SpellTrapZones { get; set; } = new SpellTrapZone[3]
        {
            new SpellTrapZone(),
            new SpellTrapZone(),
            new SpellTrapZone()
        };
        public FieldZone FieldZone { get; set; } = new FieldZone();
        public List<YugiohFieldProtection> FieldProtections { get; set; } = new List<YugiohFieldProtection>();

        public void NormalSummon(Monster monster)
        {
            if (HasFreeMonsterZone() == false)
            {
                throw new Exception("No free zones to summon to");
            }
            var freeZone = MonsterZones.ToList().FindIndex(z => z.Monster == null);
            MonsterZones[freeZone].Monster = monster;
            MonsterZones[freeZone].AttackPosition = true;
            MonsterZones[freeZone].FaceUp = true;
            monster.Location = CardLocation.MonsterZone;
            monster.Position = CardPosition.FaceUpAttack;
        }

        public void NormalSet(Monster monster)
        {
            if (HasFreeMonsterZone() == false)
            {
                throw new Exception("No free zones to set to");
            }
            var freeZone = MonsterZones.ToList().FindIndex(z => z.Monster == null);
            MonsterZones[freeZone].Monster = monster;
            MonsterZones[freeZone].AttackPosition = false;
            MonsterZones[freeZone].FaceUp = false;
            monster.Location = CardLocation.MonsterZone;
            monster.Position = CardPosition.FaceDownDefense;
        }

        public void TributeSummon(Monster monster)
        {
            var requiredTributes = 0;
            if (monster.Level == 5 || monster.Level == 6)
                requiredTributes = 1;
            if (monster.Level >= 7)
                requiredTributes = 2;

            var monstersOnBoard = MonsterZones.Where(z => z.Monster != null).Count();
            if (monstersOnBoard < requiredTributes)
                throw new Exception("Not enough monsters on the field to tribute.");
        }
    }
}
