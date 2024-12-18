using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

public class OrderManagementContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    public OrderManagementContext(DbContextOptions<OrderManagementContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderId, od.ProductId });

        modelBuilder.Entity<OrderDetail>().HasOne(od => od.oder).WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderId);

        modelBuilder.Entity<Order>().HasOne(o => o.user).WithMany(u => u.Orders).HasForeignKey(o => o.UserId);

        modelBuilder.Entity<OrderDetail>().HasOne(od => od.product).WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.ProductId);

        
    }
    
}