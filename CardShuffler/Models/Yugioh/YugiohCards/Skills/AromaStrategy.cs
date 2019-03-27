using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class AromaStrategy : Skill
    {
        public AromaStrategy(YugiohGame game) : base(game)
        {
            Name = "Aroma Strategy";
            Character = "Mai";
            SetCodes.Add("SS02-ENCS1");
        }
    }
}
