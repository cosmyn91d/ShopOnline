using Shop.Core.DomainEntities;
using Shop.Core.RepositoriesInterface.Interfaces;

namespace Shop.DAL.RepoSQL;


public class ProductRepository : IProductRepository
{
    private readonly ShopOnlineDbContext _dbContext;
    public ProductRepository(ShopOnlineDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public bool AddProduct(Product productModel)
    {
        throw new NotImplementedException();
    }

    public bool DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public bool EditProduct(Product productModel)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _dbContext.Products.ToList();
    }

    public Product GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public void SaveSchanges()
    {
        throw new NotImplementedException();
    }
}