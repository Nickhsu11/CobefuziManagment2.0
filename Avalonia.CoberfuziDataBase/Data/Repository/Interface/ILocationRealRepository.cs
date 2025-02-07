using System.Threading.Tasks;
using Avalonia.CoberfuziDataBase.Domain.Entity;

namespace Avalonia.CoberfuziDataBase.Data.Repository.Interface;

public interface ILocationRealRepository
{
    
        
    Task AddAsync (LocationReal locationReal);
    
    Task<LocationReal> GetByIdAsync(int locationrealid);
    
}