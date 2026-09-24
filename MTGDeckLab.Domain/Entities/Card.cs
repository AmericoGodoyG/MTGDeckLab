
namespace MTGDeckLab.Domain.Entities
{
    public class Card
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ManaCost { get; set; }

        public string Type { get; set; }

        public string OracleText { get; set; }

        public string SetCode { get; set; }

        // Navigation property for the relationship with DeckCard
        public ICollection<DeckCard> DeckCards { get; set; }
    }
}
