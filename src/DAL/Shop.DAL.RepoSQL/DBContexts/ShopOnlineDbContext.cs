using Microsoft.EntityFrameworkCore;
using Shop.Core.DomainEntities;

namespace Shop.DAL.RepoSQL;

public class ShopOnlineDbContext : DbContext    
{
    public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Product { get; set; }
}