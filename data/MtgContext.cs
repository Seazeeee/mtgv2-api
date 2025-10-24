using Microsoft.EntityFrameworkCore;
using mtgv2_api.Models;

namespace mtgv2_api.Data
{
    public class MtgContext : DbContext
    {
        public MtgContext(DbContextOptions<MtgContext> options) : base(options)
        {
        }
        
        public DbSet<Card> Cards { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Card entity
            modelBuilder.Entity<Card>(entity =>
            {
                // Set oracle_id as primary key
                entity.HasKey(e => e.oracle_id);
                
                // Specify the table/view name in your database
                entity.ToTable("mart_card_catalog");
                
                // Map specific columns if needed (uncomment and modify as needed)
                // entity.Property(e => e.oracle_id).HasColumnName("oracle_id");
                // entity.Property(e => e.card_name).HasColumnName("card_name");
                // entity.Property(e => e.mana_cost).HasColumnName("mana_cost");
                
                // Configure indexes for better performance
                entity.HasIndex(e => e.scryfall_id).IsUnique();
                entity.HasIndex(e => e.card_name);
                entity.HasIndex(e => e.set);
                entity.HasIndex(e => e.rarity);
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}