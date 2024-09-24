using System;

namespace Program.Models;

public class AppUser
{
 


    //CodeFirst c# 'da tabloları oluşturarak database'e tablo ekleme
    //scaffolding database manuel tablo ekleyerek ilgili tabloları c# ekleme
    public string Email { get; set; }
    public string Password { get; set; }
    public int BasketId { get; set; }
    public Basket Basket {get; set;} 
    public virtual ICollection<Order> Orders {get; set;}

   
}
