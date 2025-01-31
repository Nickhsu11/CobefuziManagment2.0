using System.Threading.Tasks;
using Avalonia.CoberfuziDataBase.Domain.Entity;

namespace Avalonia.CoberfuziDataBase.Data.Repository.Interface;

public interface IContactRepository
{
    
    Task AddAsync(Contact contact);
    
    Task<Contact> GetByIdAsync(int id);
}