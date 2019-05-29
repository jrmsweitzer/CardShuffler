using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Polymerization : NormalSpell
    {
        public Polymerization(YugiohGame game) : base(game)
        {
            Name = "Polymerization";
            SetCodes.Add("SS02-ENB11");
            CardCode = 24094653;
            Description = "Fusion Summon 1 Fusion Monster from your Extra Deck, using monsters from your hand or field as Fusion Material.";
        }
    }
}
