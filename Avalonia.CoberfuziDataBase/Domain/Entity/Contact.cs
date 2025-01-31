namespace Avalonia.CoberfuziDataBase.Domain.Entity;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Contact
{
    
    [Required]
    public int ContactID { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public string Email { get; set; }
    
}