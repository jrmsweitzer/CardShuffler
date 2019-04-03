using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class HarpiesPetDragon : EffectMonster
    {
        public HarpiesPetDragon(YugiohGame game) : base(game)
        {
            Name = "Harpie's Pet Dragon";
            SetCodes.Add("SBLS-EN020");
        }
    }
}
