using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Avalonia.CoberfuziDataBase.Domain.Entity;

public class Client : Entity
{
    [Key]
    public int ClientId { get; set; }
    
    public LocationReal HeadQuarters { get; set; }
    
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}