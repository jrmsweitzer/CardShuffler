using SDO.Models.Yugioh.YugiohCardTypes;
using System.Linq;

namespace SDO.Models.Yugioh.YugiohCards.Monsters
{
    public class DarkMagicianGirl : EffectMonster
    {
        public DarkMagicianGirl(YugiohGame game) : base(game)
        {
            Name = "Dark Magician Girl";
            Attribute = MonsterAttribute.Dark;
            Level = 6;
            Type = MonsterType.Spellcaster;
            ATK = GetAttack();
            DEF = 1700;
            SetCodes.Add("SS01-ENA04");
            SetCodes.Add("STP1-EN002");
            CardCode = 38033121;
            Description = "Gains 300 ATK for every \"Dark Magician\" or \"Magician of Black Chaos\" in the GY.";
        }

        private int GetAttack()
        {
            if (TurnPlayer == null)
                return 2000;
            if (DefendingPlayer == null)
                return 2000;
            return 2000 +
                 (TurnPlayer.DiscardPile.Where(card => card is Monster monster && monster.Name == "Dark Magician").Count() * 300) +
                 (TurnPlayer.DiscardPile.Where(card => card is Monster monster && monster.Name == "Magician of Black Chaos").Count() * 300) +
                 (DefendingPlayer.DiscardPile.Where(card => card is Monster monster && monster.Name == "Dark Magician").Count() * 300) +
                 (DefendingPlayer.DiscardPile.Where(card => card is Monster monster && monster.Name == "Magician of Black Chaos").Count() * 300);
        }
    }
}
