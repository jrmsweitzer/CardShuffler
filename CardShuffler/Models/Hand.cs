using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;
using System.Linq;

namespace CardShuffler.Models
{
    public class Hand
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public void Add(Card card)
        {
            Cards.Add(card);
        }

        public List<Card> GetMonstersThatCanBeNormalSummoned()
        {
            var normalMonstersLv4orLower = Cards.Where(c => c.GetType() == typeof(NormalMonster) && ((NormalMonster)c).Level <= 4).ToList();
            var effectMonstersLv4OrLowerThatCanBeNormalSummoned = Cards.Where(c => c.GetType() == typeof(EffectMonster) &&
                    ((EffectMonster)c).CanBeNormalSummoned &&
                    ((EffectMonster)c).Level <= 4);

            var properMonsters = normalMonstersLv4orLower;
            properMonsters.AddRange(effectMonstersLv4OrLowerThatCanBeNormalSummoned);

            return properMonsters;
        }
    }
}
