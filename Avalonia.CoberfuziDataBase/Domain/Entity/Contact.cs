namespace Avalonia.CoberfuziDataBase.Domain.Entity;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Contact
{
    
    [Key]
    public int ContactID { get; set; }

    public string Name { get; set; }
    
    public int CountryCode { get; set; }
    public int PhoneNumber { get; set; }
    
    public string Email { get; set; }
    
    public int EntityID { get; set; }
    
    public Entity Entity { get; set; }
    
}