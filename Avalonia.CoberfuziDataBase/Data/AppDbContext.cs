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

    // Function that contains the connections of CONTACT
    private void ContactModelSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>()
            .HasIndex(c => c.ContactID)
            .IsUnique();

        modelBuilder.Entity<Contact>()
            .HasIndex(c => c.PhoneNumber)
            .IsUnique();
        
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