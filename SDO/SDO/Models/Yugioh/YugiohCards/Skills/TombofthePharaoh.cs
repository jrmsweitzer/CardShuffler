using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TombofthePharaoh : Skill
    {
        public TombofthePharaoh(YugiohGame game) : base(game)
        {
            Name = "Tomb of the Pharoah";
            Character = "Ishizu";
            SetCodes.Add("SBLS-ENS06");
        }
    }
}
