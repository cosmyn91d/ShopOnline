using Microsoft.EntityFrameworkCore;
using Shop.Core.DomainEntities;
using Shop.Core.RepositoriesInterface;

namespace Shop.DAL.RepoSQL;

public abstract class DALRepository<T>: IRepository<T> where T : EntityBase
{
    protected abstract DbSet<T> dbSet { get; }

    protected readonly ShopOnlineDbContext _dbContext;

    public DALRepository(ShopOnlineDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IEnumerable<T> GetAll()
    {
        return dbSet.ToList();
    }

    public T? GetById(int id)
    {
        return dbSet.FirstOrDefault(x => x.Id == id);
    }

    public int Add(T entity)
    {
        dbSet.Add(entity);
        return _dbContext.SaveChanges();
    }

    public int Update(T entity)
    {
        dbSet.Update(entity);
        return _dbContext.SaveChanges();
    }
}

public class ProductRepository : DALRepository<Product>, IProductRepository
{
    public ProductRepository(ShopOnlineDbContext dbContext) : base(dbContext) { }

    protected override DbSet<Product> dbSet => _dbContext.Product;

    public Product? GetProductByName(string name)
    {
        return dbSet.FirstOrDefault(x => x.Name == name);
    }
}