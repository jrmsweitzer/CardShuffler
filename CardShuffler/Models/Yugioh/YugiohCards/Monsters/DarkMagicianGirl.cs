using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class DarkMagicianGirl : EffectMonster
    {
        public DarkMagicianGirl(YugiohGame game) : base(game)
        {
            Name = "Dark Magician Girl";
            Attribute = MonsterAttribute.Dark;
            Level = 6;
            Type = MonsterType.Spellcaster;
            ATK = 2000 +
                 (TurnPlayer.DiscardPile.Where(card => card is Monster monster && monster.Name == "Dark Magician").Count() * 300) +
                 (TurnPlayer.DiscardPile.Where(card => card is Monster monster && monster.Name == "Magician of Black Chaos").Count() * 300) +
                 (DefendingPlayer.DiscardPile.Where(card => card is Monster monster && monster.Name == "Dark Magician").Count() * 300) +
                 (DefendingPlayer.DiscardPile.Where(card => card is Monster monster && monster.Name == "Magician of Black Chaos").Count() * 300);
            DEF = 1700;
        }
    }
}
