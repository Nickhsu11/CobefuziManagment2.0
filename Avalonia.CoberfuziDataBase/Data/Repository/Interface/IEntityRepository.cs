using System.Threading.Tasks;
using Avalonia.CoberfuziDataBase.Domain.Entity;

namespace Avalonia.CoberfuziDataBase.Data.Repository.Interface;

public interface IEntityRepository<T> where T : Entity
{
    
    Task AddAsync(T entity);
    
    Task<T> GetByIdAsync(int id);
    
}