using System.Threading.Tasks;
using Avalonia.CoberfuziDataBase.Domain.Entity;

namespace Avalonia.CoberfuziDataBase.Data.Repository.Interface;

public interface IClientRepository : IEntityRepository<Client>
{
    
    Task<Client> GetClientByIdAsync(int clientId);
    
}