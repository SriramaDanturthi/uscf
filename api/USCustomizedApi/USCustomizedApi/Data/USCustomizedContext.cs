using Microsoft.EntityFrameworkCore;
using USCustomizedApi.Data.Models;

namespace USCustomizedApi.Data
{
  public class USCustomizedContext : DbContext
  {
    public USCustomizedContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<ColorOption> ColorsOption { get; set; }
    public DbSet<EdgeProfile> EdgeProfiles { get; set; }
    public DbSet<ImageType> ImageTypes { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Panel> Panel { get; set; }
    public DbSet<PanelType> PanelTypes { get; set; }
    public DbSet<ProductEdgeProfile> ProductEdgeProfiles { get; set; }
    public DbSet<ProductImage>  ProductImages { get; set; }
    public DbSet<ProductNote> ProductNotes {  get; set; }
    public DbSet<ProductProperty> ProductProperties {  get; set; }
    public DbSet<Property> Properties { get; set; }
    public DbSet<Testimonial> Testsimonial {  get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Category>().ToTable("Category");
      modelBuilder.Entity<Product>().ToTable("Product");
      modelBuilder.Entity<Color>().ToTable("Color");
      modelBuilder.Entity<ColorOption>().ToTable("ColorOption");
      modelBuilder.Entity<EdgeProfile>().ToTable("EdgeProfile");
      modelBuilder.Entity<ImageType>().ToTable("ImageType");
      modelBuilder.Entity<Note>().ToTable("Note");
      modelBuilder.Entity<Panel>().ToTable("Panel");
      modelBuilder.Entity<PanelType>().ToTable("PanelType");
      modelBuilder.Entity<ProductEdgeProfile>().ToTable("ProductEdgeProfile");
      modelBuilder.Entity<ProductImage>().ToTable("ProductImage");
      modelBuilder.Entity<ProductNote>().ToTable("ProductNote");
      modelBuilder.Entity<ProductProperty>().ToTable("ProductProperty");
      modelBuilder.Entity<Property>().ToTable("Property");
      modelBuilder.Entity<Testimonial>().ToTable("Testimonial");

      base.OnModelCreating(modelBuilder);
    }
  }
}
