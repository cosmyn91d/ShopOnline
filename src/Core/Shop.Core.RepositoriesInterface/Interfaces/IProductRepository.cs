using Shop.Core.DomainEntities;
using Shop.Core.DomainEntities.Models;

namespace Shop.Core.RepositoriesInterface.Interfaces;

public interface IProductRepository
{
    public Product GetProductById(int id);
    public IEnumerable<Product> GetAllProducts();
    public void AddProduct(Product productModel);
    public void EditProduct(Product productModel);
    public void DeleteProduct(int id);
    public void SaveSchanges();
}