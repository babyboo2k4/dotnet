using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models;

public class OrderDetail
{
    [Key]
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public virtual Order oder { get; set; }
    public virtual Product product { get; set; }
    public int Quality { get; set; }
    public decimal UnitPrice { get; set; }
}