namespace WebApplication5.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public int UserId { get; set; }
    public virtual User user { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}

