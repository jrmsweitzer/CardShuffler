namespace CardShuffler.Models.SFL.Phases
{
    public class DrawPhase
    {
        public void Execute(Deck deck, Hand hand)
        {
            deck.DrawACardFromTop(hand);
            deck.DrawACardFromTop(hand);
        }
    }
}
