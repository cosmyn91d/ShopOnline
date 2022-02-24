using Shop.Core.Business.Interfaces;
using Shop.Core.DomainEntities;
using Shop.Core.RepositoriesInterface.Interfaces;

namespace Shop.Core.Business;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IEnumerable<Product> GetAllProducts()
    {
        return _productRepository.GetAllProducts();
    }

    public Product GetProductById(int id)
    {
        throw new NotImplementedException();
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
}