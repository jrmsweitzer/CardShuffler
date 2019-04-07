using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class RoyalFlush : Skill
    {
        public RoyalFlush(YugiohGame game) : base(game)
        {
            Name = "Royal Flush";
            Character = "Yami Yugi";
            SetCodes.Add("SBLS-ENS04");
            Description = "Once per turn, if you control \"Queen's Knight\", you can pay 1000 LP to Normal Summon 1 \"King's Knight\" in addition to your Normal Summon or Set. \"King's Knight\" and \"Jack's Knight\" you control cannot attack directly the turn you use this Skill.";
        }
    }
}
