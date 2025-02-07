using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Avalonia.Controls;

namespace Avalonia.CoberfuziDataBase.Domain.Entity;

public class Project
{
    
    [Key]
    public int ProjectId { get; set; }
    
    public LocationReal location { get; set; }
    
    public DateTime startDate { get; set; }
    
    public string MaterialType { get; set; }

    public ICollection<PDFfile> GTs { get; set; } = new List<PDFfile>();

    public ICollection<PDFfile> WorkSheet { get; set; } = new List<PDFfile>();
    
    public int SiteResponsibleID { get; set; }
    public Contact SiteResponsible { get; set; }
    
    public int ClientID { get; set; }
    public Client client { get; set; }
    
}