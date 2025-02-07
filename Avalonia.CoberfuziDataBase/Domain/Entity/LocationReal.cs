using System.ComponentModel.DataAnnotations;

namespace Avalonia.CoberfuziDataBase.Domain.Entity;

public class LocationReal
{
    
    [Key]
    public int LocationRealId { get; set; }
    
    public string Country { get; set; }
    
    public string City { get; set; }
    
    public string Region { get; set; }
    
    public string Street { get; set; }
    
    public string BuildingNumber { get; set; }
    
    public string Floor { get; set; }
    
    public string PostCode { get; set; }
    
}