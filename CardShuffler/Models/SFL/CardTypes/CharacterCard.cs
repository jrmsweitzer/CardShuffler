namespace CardShuffler.Models.SFL.CardTypes
{
    public class CharacterCard: SFLGameCard
    {
        public bool IsHero { get; set; }
        public bool IsVillian { get; set; }
        public int Health { get; set; }
        public string Race1 { get; set; }
        public string Race2 { get; set; }
        public SFLTrait Trait { get; set; }
        public string Class1 { get; set; }
        public string Class2 { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
    }
}
