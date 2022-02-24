using Shop.Core.DomainEntities;
using Shop.Core.RepositoriesInterface.Interfaces;

namespace Shop.DAL.RepoSQL;

public class ProductRepository : IProductRepository
{
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
        throw new NotImplementedException();
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