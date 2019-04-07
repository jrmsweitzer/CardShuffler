using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class PalOMinezation : Skill
    {
        public PalOMinezation(YugiohGame game) : base(game)
        {
            Name = "Pal-O'Mine-zation";
            Character = "Joey";
            SetCodes.Add("SS02-ENBS3");
            Description = "During your turn, you may reveal 1 Normal Monster in your hand. This turn, that monster can substitute for any 1 Fusion Material. If you do, the other Fusion Material(s) must be the correct one(s). This Skill can only be used once per Duel.";
        }
    }
}
