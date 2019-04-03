using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Relinquished : RitualMonster
    {
        public Relinquished(YugiohGame game) : base(game)
        {
            Name = "Relinquished";
            RitualSpellCardName = "Black Illusion Ritual";
            SetCodes.Add("SS01-ENC08");
        }
    }
}
