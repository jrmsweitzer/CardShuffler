namespace CardShuffler.Models.Yugioh.YugiohCardTypes
{
    public class RitualMonster : EffectMonster
    {
        public RitualMonster(YugiohGame game) : base(game)
        {
        }

        public string RitualSpellCardName { get; set; }
    }
}
