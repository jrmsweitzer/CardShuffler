using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class MillenniumEye : Skill
    {
        public MillenniumEye(YugiohGame game) : base(game)
        {
            Name = "Millennium Eye";
            Character = "Pegasus";
            SetCodes.Add("SS01-ENCS3");
            Description = "At the start of the Duel, look at your opponent's opening hand. You may choose to have that player shuffle their hand into their Deck and draw a new hand. (If both players use a Skill at the same time, the Turn player resolves their Skill first.)";
        }
    }
}
