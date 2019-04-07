using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SphereKuriboh : EffectMonster
    {
        public SphereKuriboh(YugiohGame game) : base(game)
        {
            Name = "Sphere kuriboh";
            Attribute = MonsterAttribute.Dark;
            Level = 1;
            Type = MonsterType.Fiend;
            ATK = 300;
            DEF = 200;
            SetCodes.Add("SBLS-EN018");
            CardCode = 33245030;
            Description = "When an opponent's monster declares an attack: You can send this card from your hand to the GY; change the attacking monster to Defense Position. When you Ritual Summon, you can banish this card from your GY as 1 of the monsters required for the Ritual Summon.";
        }
    }
}
