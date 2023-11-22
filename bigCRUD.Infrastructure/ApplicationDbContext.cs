using bigCRUD.Application.Models;
using Microsoft.EntityFrameworkCore;


namespace bigCRUD.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(p => p.Product)
                .WithOne(c => c.Category)
                .OnDelete(DeleteBehavior.Cascade); // Configure cascading delete

            base.OnModelCreating(modelBuilder);
        }


    }
}
