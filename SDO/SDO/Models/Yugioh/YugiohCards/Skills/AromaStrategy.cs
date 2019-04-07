using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class AromaStrategy : Skill
    {
        public AromaStrategy(YugiohGame game) : base(game)
        {
            Name = "Aroma Strategy";
            Character = "Mai";
            SetCodes.Add("SS02-ENCS1");
            SkillActivationDescription = "At the start of the Duel, flip this card over.";
            Description = "You may look at the top card of your Deck at any time.";
        }
    }
}
