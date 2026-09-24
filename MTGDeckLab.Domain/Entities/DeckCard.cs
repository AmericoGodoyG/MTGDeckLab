
namespace MTGDeckLab.Domain.Entities
{
    public class DeckCard
    {
        public int Id { get; set; }

        public int DeckId { get; set; }

        public int CardId { get; set; }

        public int Quantity { get; set; }


        // Properties for navigation
        public Deck Deck { get; set; }
        public Card Card { get; set; }
    }
}
