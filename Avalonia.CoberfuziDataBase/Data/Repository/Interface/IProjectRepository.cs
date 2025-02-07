using System.Threading.Tasks;
using Avalonia.CoberfuziDataBase.Domain.Entity;

namespace Avalonia.CoberfuziDataBase.Data.Repository.Interface;

public interface IProjectRepository
{
        
    Task AddAsync(Project project);
    
    Task<Project> GetByIdAsync(int projectId);
    
}