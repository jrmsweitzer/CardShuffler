using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ZombieTiger : UnionMonster
    {
        public ZombieTiger(YugiohGame game) : base(game)
        {
            Name = "Zombie Tiger";
            SetCodes.Add("SBLS-EN033");
            Attribute = MonsterAttribute.Earth;
            Level = 3;
            Type = MonsterType.Zombie;
            ATK = 1400;
            DEF = 1600;
            CardCode = 47693640;
            Description = "Once per turn, you can either: Target 1 \"Decayed Commander\" you control; equip this card to that target, OR: Unequip this card and Special Summon it in Attack Position. While equipped by this effect, the equipped monster gains 500 ATK/DEF. If the equipped monster destroys an opponent's monster by battle: Discard 1 random card from their hand. (A monster can only be equipped with 1 Union monster at a time. If the equipped monster would be destroyed by battle, destroy this card instead.)";
        }
    }
}
