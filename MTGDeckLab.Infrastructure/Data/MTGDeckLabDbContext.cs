using Microsoft.EntityFrameworkCore;
using MTGDeckLab.Domain.Entities;

namespace MTGDeckLab.Infrastructure.Data
{
    public class MTGDeckLabDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<DeckCard> DeckCards { get; set; }

        public MTGDeckLabDbContext(DbContextOptions<MTGDeckLabDbContext> options) : base(options)
        {

        }

    }
}
