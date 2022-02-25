using Shop.Core.DomainEntities;
using Shop.Core.DomainEntities.Models;
using Shop.Core.RepositoriesInterface.Interfaces;

namespace Shop.DAL.RepoSQL;


public class ProductRepository : IProductRepository
{
    private readonly ShopOnlineDbContext _dbContext;
    public ProductRepository(ShopOnlineDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IEnumerable<Product> GetAllProducts()
    {
        return _dbContext.Product.ToList();
    }

    public Product GetProductById(int id)
    {
        return _dbContext.Product.FirstOrDefault(x => x.Id == id);
    }

    public void AddProduct(Product product)
    {
         _dbContext.Product.Add(product);
    }

    public void DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public void EditProduct(Product productModel)
    {
        _dbContext.Product.Update(productModel);
    }

    public void SaveSchanges()
    {
        _dbContext.SaveChanges();
    }
}