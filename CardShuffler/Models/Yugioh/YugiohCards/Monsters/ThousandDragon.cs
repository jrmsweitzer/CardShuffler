using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class ThousandDragon : NormalFusionMonster
    {
        public ThousandDragon(YugiohGame game) : base(game)
        {
            Name = "Thousand Dragon";
            SetCodes.Add("SS02-ENB21");

            FusionMaterials = new List<string>()
            {
                "Baby Dragon",
                "Time Wizard"
            };
        }
    }
}
