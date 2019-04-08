namespace SDO.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SDODBContext : DbContext
    {
        public SDODBContext()
            : base("name=SDODB")
        {
        }

        public virtual DbSet<Deck> Decks { get; set; }
        public virtual DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Decks)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);
        }
    }
}
