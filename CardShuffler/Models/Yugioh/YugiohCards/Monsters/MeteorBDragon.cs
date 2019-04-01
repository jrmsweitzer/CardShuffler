using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class MeteorBDragon : NormalFusionMonster
    {
        public MeteorBDragon(YugiohGame game) : base(game)
        {
            Name = "Meteor B. Dragon";
            FusionMaterials = new List<string>()
            {
                "Meteor Dragon",
                "Red-Eyes B. Dragon"
            };
            SetCodes.Add("SBLS-EN013");
        }
    }
}
