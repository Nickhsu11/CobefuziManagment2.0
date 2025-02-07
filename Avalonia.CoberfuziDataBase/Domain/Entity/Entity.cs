using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Avalonia.CoberfuziDataBase.Domain.Entity;

public abstract class Entity
{
    
    [Key]
    public int EntityID { get; set; }
    
    public string Name { get; set; }

    public int NIF { get; set; }

    public ICollection<Contact> ContactList { get; set; } = new List<Contact>();

}