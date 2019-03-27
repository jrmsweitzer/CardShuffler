using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ItsaToonWorld : Skill
    {
        public ItsaToonWorld(YugiohGame game) : base(game)
        {
            Name = "It's a Toon World!";
            Character = "Pegasus";
            SetCodes.Add("SS01-ENCS1");
        }
    }
}
