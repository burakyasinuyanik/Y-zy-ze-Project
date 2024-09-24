using System;

namespace Program.Models;

public abstract class BaseModel
{
  

    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateCreated { get; set; }= DateTime.Now;
 
}
