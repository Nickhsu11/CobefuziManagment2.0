using System.ComponentModel.DataAnnotations;

namespace Avalonia.CoberfuziDataBase.Domain.Entity;

public class PDFfile
{
    
    [Key]
    public int PDFfileID { get; set; }
    
    public string PDFFileName { get; set; }
    
    public byte[] PDFFileContent { get; set; }
    
    public int ProjectID { get; set; }
    public Project Project { get; set; }
    
}