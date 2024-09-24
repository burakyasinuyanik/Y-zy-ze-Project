using System;

namespace Program.Models;

public class Order
{
    

    public decimal TotalAmaunt { get; set; }
    public int AppUserId { get; set; }
    public virtual AppUser AppUser {get; set;}
    public virtual ICollection<OrderProduct> OrderProducts {get;set;}
}
