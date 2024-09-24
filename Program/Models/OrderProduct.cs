using System;

namespace Program.Models;

public class OrderProduct
{
    

    public int OrderId { get; set; }
    public virtual Order Order {get;set;}
    public string Barcode {get;set;}
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    //property özellik
    //field  değişken
    private decimal totalPrice {get;set;}
    public decimal TotalPrice
    {
        get { return totalPrice=Price*Quantity; }
        //set { TotalPrice = Price*Quantity; }
    }
    
    
    
}
