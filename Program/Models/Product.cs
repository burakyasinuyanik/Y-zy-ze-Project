using System;
using Program.Models;

namespace Program;

public class Product
{
  

    public int  Stock { get; set; }
    public int RemainStock { get; set; }
    public string Barcode { get; set; }
    public decimal Price {get;set;}
    public ICollection<Basket> Baskets { get; set; }
}
