using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;

public class AlBaDbContext : DbContext
{
    public AlBaDbContext(DbContextOptions<AlBaDbContext> options) : base(options)
    {
    }

    public DbSet<Delivery> Delivery { get; set; } = default!;
    public DbSet<Product> Product { get; set; } = default!;
    public DbSet<Warehouse> Warehouse { get; set; } = default!;
    public DbSet<Balance> Balance { get; set; } = default!;

}