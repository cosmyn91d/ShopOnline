using Shop.Core.DomainEntities;

namespace Shop.Core.RepositoriesInterface.Interfaces;

public interface IProductRepository
{
    public Product GetProductById(int id);
    public IEnumerable<Product> GetAllProducts();
    public bool AddProduct(Product productModel);
    public bool EditProduct(Product productModel);
    public bool DeleteProduct(int id);
    public void SaveSchanges();
}