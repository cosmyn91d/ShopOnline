using Shop.Core.Business.Interfaces;
using Shop.Core.DomainEntities;
using Shop.Core.DomainEntities.Models;
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
        var product = _productRepository.GetProductById(id);
        return product;
    }

    public bool AddProduct(ProductModel productModel)
    {
        var hasProduct = _productRepository.GetAllProducts().FirstOrDefault(x => x.Name == productModel.Name);

        if (hasProduct is not null) {
            throw new ArgumentException($"Product with name {productModel.Name} already exists!");
        }

        var product = new Product {
            Name = productModel.Name,
            Code = productModel.Code,
            CategoryId = productModel.CategoryId,
            Description = productModel.Description,
            Price = productModel.Price,
            Stock = productModel.Stock,
            IsDeleted = false,
            IsDisabled = false,
            CreateTime = DateTime.UtcNow,
            ModifyTime = DateTime.UtcNow
        };

        // TO DO
        // verify if CategoryId of the product exists

        _productRepository.AddProduct(product);
        _productRepository.SaveSchanges();
        return true;
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