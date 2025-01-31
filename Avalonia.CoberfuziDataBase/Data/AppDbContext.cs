using Avalonia.CoberfuziDataBase.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Avalonia.CoberfuziDataBase.Data;

public class AppDbContext : DbContext
{
    
    public DbSet<Contact> Contacts { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
    
}