using Shop.Core.DomainEntities;
using Shop.Core.DomainEntities.Models;

namespace Shop.Core.Business.Interfaces;

public interface IProductService
{
    public Product GetProductById(int id);
    public IEnumerable<Product> GetAllProducts();
    public bool AddProduct(ProductAddModel productModel);
    public bool EditProduct(ProductEditModel product);
    public bool DeleteProduct(int id);

}

