using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ShadowofEyes : NormalTrap
    {
        public ShadowofEyes(YugiohGame game) : base(game)
        {
            Name = "Shadow of Eyes";
            SetCodes.Add("SS02-ENC17");
            CardCode = 58621589;
            Description = "When a monster(s) is Set on your opponent's field: Target 1 of those Set monsters; change that Set monster to face-up Attack Position. (Flip Effects are not activated.)";
        }
    }
}
