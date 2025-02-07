using System.Threading.Tasks;
using Avalonia.CoberfuziDataBase.Data.Repository.Interface;
using Avalonia.CoberfuziDataBase.Domain.Entity;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Avalonia.CoberfuziDataBase.Data.Repository.Class;

public class ContactRepository : IContactRepository
{
    
    private readonly AppDbContext _context;

    public ContactRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task AddAsync(Contact contact)
    {
        try
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException ex) when (ex.InnerException is SqliteException sqliteEx)
        {
            
        }
    }

    public async Task<Contact> GetByIdAsync(int id)
    {
        return await _context.Contacts.FindAsync(id);
    }
    
}