using Shop.Core.DomainEntities;

namespace Shop.Core.Business.Interfaces;

public interface IProductService
{
    public Product GetProductById(int id);
    public IEnumerable<Product> GetAllProducts();
    public bool AddProduct(Product productModel);
    public bool EditProduct(Product productModel);
    public bool DeleteProduct(int id);

}

