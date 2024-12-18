namespace WebApplication5.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; }
}

