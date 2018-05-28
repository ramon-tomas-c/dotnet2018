using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

/// <summary>
/// Summary description for BeersContext
/// </summary>
public class BeersContext : DbContext
{
    public BeersContext() : base(AppConfiguration.ConnectionString)
    {
        
    }

    public DbSet<Beer> Beers { get; set; }

    protected override void OnModelCreating(DbModelBuilder builder)
    {
        ConfigureBeerType(builder.Entity<Beer>()); ;
    }

    void ConfigureBeerType(EntityTypeConfiguration<Beer> builder)
    {
        builder.ToTable("Beers");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
           .IsRequired();

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Code)
            .IsRequired()
            .HasMaxLength(50);
    }
}