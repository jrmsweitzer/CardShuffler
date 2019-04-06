using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BlastHeldbyaTribute : NormalTrap
    {
        public BlastHeldbyaTribute(YugiohGame game) : base(game)
        {
            Name = "Blast Held by a Tribute";
            SetCodes.Add("SS01-ENB15");
            CardCode = 89041555;
            Description = "When an opponent's monster that was Tribute Summoned declares an attack: Destroy as many face-up Attack Position monsters they control as possible, and if you do, inflict 1000 damage to your opponent.";
        }
    }
}
