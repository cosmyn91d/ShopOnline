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

    public bool AddProduct(ProductAddModel productModel)
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
        var hasProduct = _productRepository.GetProductById(id);

        if (hasProduct is null)
        {
            throw new ArgumentException($"Product with id {id} does not exists!");
        }

        if (hasProduct.IsDeleted == true) {
            throw new Exception($"Product with id {id} is already deleted!");
        }

        hasProduct.IsDeleted = true;

        _productRepository.EditProduct(hasProduct);
        _productRepository.SaveSchanges();

        return true;
    }

    public bool EditProduct(ProductEditModel product)
    {
        var hasProduct = _productRepository.GetProductById(product.Id);

        if (hasProduct is null)
        {
            throw new ArgumentException($"Product with id {product.Id} does not exists!");
        }

        hasProduct.Name = product.Name;
        hasProduct.Code = product.Code;
        hasProduct.CategoryId = product.CategoryId;
        hasProduct.Description = product.Description;
        hasProduct.Price = product.Price;
        hasProduct.Stock = product.Stock;
        hasProduct.IsDeleted = product.IsDeleted;
        hasProduct.IsDisabled = product.IsDisabled;
        hasProduct.ModifyTime = DateTime.UtcNow;

        _productRepository.EditProduct(hasProduct);
        _productRepository.SaveSchanges();

        return true;
    }
}