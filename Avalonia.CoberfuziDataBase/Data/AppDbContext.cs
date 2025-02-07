using Avalonia.CoberfuziDataBase.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Avalonia.CoberfuziDataBase.Data;

public class AppDbContext : DbContext
{
    
    public DbSet<Contact> Contacts { get; set; }
    
    public DbSet<LocationReal> Locations { get; set; }
    
    public DbSet<PDFfile> PDFfiles { get; set; }
    
    public DbSet<Project> Projects { get; set; }
    
    public DbSet<Client> Clients { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        ContactModelSeed(modelBuilder);
        PDFfileModelSeed(modelBuilder);
        LocationRealModelSeed(modelBuilder);
    }
    
    private void EntityModelSeed(ModelBuilder modelBuilder)
    {
        // Defines that the Entity is the key
        modelBuilder.Entity<Entity>()
            .HasKey(e => e.EntityID);
        
        // Defines that each entity has many Contacts
        modelBuilder.Entity<Entity>()
            .HasMany(e => e.ContactList)
            .WithOne(e => e.Entity)
            .HasForeignKey(e => e.EntityID);
        
    }
    
    private void ContactModelSeed(ModelBuilder modelBuilder)
    {
        
        // Defines that the Contact is the Key
        modelBuilder.Entity<Contact>()
            .HasKey(e => e.EntityID);

        // Defines that each Contact has an unique Phone Number
        modelBuilder.Entity<Contact>()
            .HasIndex(c => c.PhoneNumber)
            .IsUnique();

        // Defines that each Contact has only one Entity
        modelBuilder.Entity<Contact>()
            .HasOne(c => c.Entity)
            .WithMany(e => e.ContactList)
            .HasForeignKey(c => c.EntityID);

    }
    
    // Function that contains the connections of PDFfile
    private void PDFfileModelSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PDFfile>()
            .HasIndex(p => p.PDFfileID)
            .IsUnique();

        modelBuilder.Entity<PDFfile>()
            .HasIndex(p => p.PDFFileName)
            .IsUnique();
    }

    // Function that contains the connections of LocationReal
    private void LocationRealModelSeed(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<LocationReal>()
            .HasIndex(l => l.LocationRealId)
            .IsUnique();
        
    }
}