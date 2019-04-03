using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Linq;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class Monster: YugiohGameCard
    {
        public Monster(YugiohGame game) : base(game)
        {
        }

        public bool IsFaceUpOnField()
        {
            return
                Location == CardLocation.MonsterZone &&
                (Position == CardPosition.FaceUpAttack ||
                 Position == CardPosition.FaceUpDefense);
        }

        public MonsterAttribute Attribute { get; set; }
        public MonsterType Type { get; set; }
        private int _atk;
        public int ATK
        {
            get
            {
                if (IsFaceUpOnField() == false)
                    return _atk;

                var combinedAtk = _atk;
                if (Game.FieldBuffs.Any())
                {
                    foreach (var gb in Game.FieldBuffs)
                    {
                        if (gb is YugiohFieldAttributeBuff attrBuff)
                        {
                            if (attrBuff.AffectedAttribute == Attribute)
                                combinedAtk += attrBuff.ATKBuff;
                        }
                        else if (gb is YugiohFieldTypeBuff typeBuff)
                        {
                            if (typeBuff.AffectedType == Type)
                                combinedAtk += typeBuff.ATKBuff;
                        }
                        else if (gb is YugiohNamedBuff namedBuff)
                        {
                            if (Name.Contains(namedBuff.NameIncludes))
                                combinedAtk += namedBuff.ATKBuff;
                        }
                    }
                }
                return combinedAtk;
            }
            set { _atk = value; }
        }
        private int _def;
        public int DEF
        {
            get
            {
                var combinedDEF = _def;
                if (Game.FieldBuffs.Any())
                {
                    foreach (var gb in Game.FieldBuffs)
                    {
                        if (gb is YugiohFieldAttributeBuff attrBuff)
                        {
                            if (attrBuff.AffectedAttribute == Attribute)
                                combinedDEF += attrBuff.DEFBuff;
                        }
                        else if (gb is YugiohFieldTypeBuff typeBuff)
                        {
                            if (typeBuff.AffectedType == Type)
                                combinedDEF += typeBuff.DEFBuff;
                        }
                        else if (gb is YugiohNamedBuff namedBuff)
                        {
                            if (Name.Contains(namedBuff.NameIncludes))
                                combinedDEF += namedBuff.DEFBuff;
                        }
                    }
                }
                return combinedDEF;
            }
            set { _def = value; }
        }
        public int Level { get; set; }
    }
}
