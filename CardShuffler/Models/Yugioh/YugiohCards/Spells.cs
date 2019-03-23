using CardShuffler.Models.Yugioh.YugiohCards;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class SpellList
    {
        public static List<YugiohGameCard> GetSpells(YugiohGame game)
        {
            return new List<YugiohGameCard>()
            {
                // A
                new AmazonessHeirloom(game),
                new AmazonessVillage(game),
                // B
                //new NormalSpell(game)
                //{
                //    Name = "Burst Stream of Destruction"
                //},
                //// C
                //new NormalSpell(game)
                //{
                //    Name = "Cost Down"
                //},
                //new EquipSpell(game)
                //{
                //    Name = "Cyber Shield"
                //},
                //// D
                //new QuickplaySpell(game)
                //{
                //    Name = "Dicephoon"
                //},
                //// E
                //new NormalSpell(game)
                //{
                //    Name = "Elegant Egotist"
                //},
                //// F
                //new FieldSpell(game)
                //{
                //    Name = "Fusion Gate"
                //},
                //// G
                //new QuickplaySpell(game)
                //{
                //    Name = "Graceful Dice"
                //},
                //// H
                //new FieldSpell(game)
                //{
                //    Name = "Harpie's Hunting Ground"
                //},
                //// I
                //// J
                //// K
                //// L
                //new EquipSpell(game)
                //{
                //    Name = "Legendary Sword"
                //},
                //// M
                //new FieldSpell(game)
                //{
                //    Name = "Mountain"
                //},
                //// N
                //// O
                //// P
                //new NormalSpell(game)
                //{
                //    Name = "Polymerization"
                //},
                //// Q
                //// R
                //// S
                //new FieldSpell(game)
                //{
                //    Name = "Sogen"
                //},
                //new NormalSpell(game)
                //{
                //    Name = "Stamping Destruction"
                //},
                //new NormalSpell(game)
                //{
                //    Name = "Stray Lambs"
                //},
                // T
                new TheFluteofSummoningDragon(game),
                new ToonRollback(game),
                new ToonTableofContents(game),
                new ToonWorld(game),
                //new NormalSpell(game)
                //{
                //    Name = "Triangle Ecstacy Spark"
                //},
                // U
                // V
                // W
                // X
                // Y
                // Z
            };
        }
    }
}
