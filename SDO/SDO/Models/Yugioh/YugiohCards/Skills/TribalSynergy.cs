using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TribalSynergy : Skill
    {
        public TribalSynergy(YugiohGame game) : base(game)
        {
            Name = "Tribal Synergy";
            Character = "Mai";
            SetCodes.Add("SS02-ENCS3");
            Description = "If you have an \"Amazoness\" monster and a \"Harpie\" monster in your hand, reveal them and draw 1 card.\n" +
"If you control an \"Amazoness\" monster and a \"Harpie\" monster, draw 2 cards.\n" +
"Each of these Skills can only be used once per Duel.";
        }
    }
}
