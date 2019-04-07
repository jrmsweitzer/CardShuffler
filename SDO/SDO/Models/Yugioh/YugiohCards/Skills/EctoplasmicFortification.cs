using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class EctoplasmicFortification : Skill
    {
        public EctoplasmicFortification(YugiohGame game) : base(game)
        {
            Name = "Ectoplasmic Fortification";
            Character = "Bonz";
            SetCodes.Add("SBLS-ENS01");
            Description = "Once per turn, if you control a Zombie monster, you can place 1 counter on this card. All Zombie monsters you control gain 100 ATK and lose 100 DEF for each counter on this card. Any battle damage you take from battles involving your Zombie monster is doubled.";
        }
    }
}
