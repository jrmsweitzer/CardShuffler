using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SonicShooter : EffectMonster
    {
        public SonicShooter(YugiohGame game) : base(game)
        {
            Name = "Sonic Shooter";
            Attribute = MonsterAttribute.Wind;
            Level = 4;
            Type = MonsterType.WingedBeast;
            ATK = 1300;
            DEF = 600;
            SetCodes.Add("SS02-ENC09");
            CardCode = 40384720;
            Description = "If there are no cards in your opponent's Spell & Trap Zone, this card can attack your opponent directly. If it does, the battle damage inflicted to your opponent is the original ATK of this card.";
        }
    }
}
