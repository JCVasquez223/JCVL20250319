using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JCVL20250319.AppWebMVC.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    [Display(Name = "Categorias")]
    public string CategoryName { get; set; } = null!;

    [Display(Name = "Descripcion")]
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
