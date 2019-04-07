using SDO.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ArcanaKnightJoker : EffectFusionMonster
    {
        public ArcanaKnightJoker(YugiohGame game) : base(game)
        {
            Name = "Arcana Knight Joker";
            FusionMaterials = new List<string>()
            {
                "King's Knight",
                "Queen's Knight",
                "Jack's Knight"
            };
            CanUseFusionSubstitutes = false;
            SetCodes.Add("SBLS-EN007");
            Attribute = MonsterAttribute.Light;
            Level = 9;
            Type = MonsterType.Warrior;
            ATK = 3800;
            DEF = 2500;
            CardCode = 06150044;
            Description = "A Fusion Summon of this card can only be done with the above materials. Once per turn, when a Spell/Trap Card, or monster effect, is activated that targets this face-up card on the field (Quick Effect): You can discard the same type of card (Monster, Spell, or Trap); negate the effect.";
        }
    }
}
