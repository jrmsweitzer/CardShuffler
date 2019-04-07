using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ChampionsVigilance : CounterTrap
    {
        public ChampionsVigilance(YugiohGame game) : base(game)
        {
            Name = "Champion's Vigilance";
            SetCodes.Add("SS02-ENV01");
            CardCode = 82382815;
            Description = "If you control a Level 7 or higher Normal Monster, when a monster would be Summoned OR a Spell/Trap Card is activated: Negate the Summon or activation, and if you do, destroy that card.";
        }
    }
}
