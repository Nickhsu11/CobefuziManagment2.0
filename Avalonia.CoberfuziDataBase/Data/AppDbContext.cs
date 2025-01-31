using Microsoft.EntityFrameworkCore;

namespace Avalonia.CoberfuziDataBase.Data;

public class AppDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
    
}