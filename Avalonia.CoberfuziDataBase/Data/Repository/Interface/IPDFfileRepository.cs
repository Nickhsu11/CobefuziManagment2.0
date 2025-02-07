using System.Threading.Tasks;
using Avalonia.CoberfuziDataBase.Domain.Entity;

namespace Avalonia.CoberfuziDataBase.Data.Repository.Interface;

public interface IPDFfileRepository
{
    
    Task AddAsync(PDFfile pdffile);
    
    Task<PDFfile> GetByIdAsync(int id);
}