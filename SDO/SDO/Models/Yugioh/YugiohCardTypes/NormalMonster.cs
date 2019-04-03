using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCardTypes
{
    public class NormalMonster: Monster
    {
        public NormalMonster(YugiohGame game) : base(game)
        {
        }

        public override string ToString()
        {
            return $"{Name} {Attribute.ToString().ToUpper()} {Level} {Type} {ATK}/{DEF}";
        }

        public NormalMonster Clone()
        {
            return new NormalMonster(Game)
            {
                ATK = ATK,
                Attribute = Attribute,
                DEF = DEF,
                Level = Level,
                Name = Name,
                Type = Type
            };
        }
    }
}
