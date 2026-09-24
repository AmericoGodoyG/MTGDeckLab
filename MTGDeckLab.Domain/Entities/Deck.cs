
namespace MTGDeckLab.Domain.Entities
{
    public class Deck
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Format { get; set; }

        public DateTime CreatedAt { get; set; }

        // Navigation property for the relationship with DeckCard
        public ICollection<DeckCard> DeckCards { get; set; }

    }
}
