using System;

namespace Program.Models;

public class Basket
{
   
    public virtual ICollection<Product> Products {get;set;}
    public int Quantity { get; set; }
    public decimal TotalAmaunt {get;set;}
}
