using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class AlligatorsSwordDragon : NormalFusionMonster
    {
        public AlligatorsSwordDragon(YugiohGame game) : base(game)
        {
            Name = "Alligator's Sword Dragon";
            SetCodes.Add("SS02-ENB22");

            FusionMaterials = new List<string>()
            {
                "Alligator's Sword",
                "Baby Dragon"
            };
        }
    }
}
