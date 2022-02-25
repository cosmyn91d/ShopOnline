using Shop.Core.DomainEntities;
using Shop.Core.RepositoriesInterface;

namespace Shop.Core.Business;
public interface IProductService
{
    public Product? GetProductById(int id);
    public IEnumerable<Product> GetAllProducts();
    public bool AddProduct(Product product);
    public bool EditProduct(Product product);
    public bool DeleteProduct(int id);
}


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

    public Product? GetProductById(int id)
    {
        return _productRepository.GetProductById(id);
    }

    public bool AddProduct(Product product)
    {
        var dbProduct = _productRepository.GetProductByName(product.Name);

        if (dbProduct != null) 
        {
            throw new ArgumentException($"Product with name {product.Name} already exists!");
        }
        //TODO: verify if CategoryId of the product exists
        int i = _productRepository.AddProduct(product);
        return i == 1;
    }

    //public bool DeleteProduct(int id)
    //{
    //    var hasProduct = _productRepository.GetProductById(id);

    //    if (hasProduct is null)
    //    {
    //        throw new ArgumentException($"Product with id {id} does not exists!");
    //    }

    //    if (hasProduct.IsDeleted == true) {
    //        throw new Exception($"Product with id {id} is already deleted!");
    //    }

    //    hasProduct.IsDeleted = true;

    //    _productRepository.EditProduct(hasProduct);
    //    _productRepository.SaveSchanges();

    //    return true;
    //}

    //public bool EditProduct(ProductEditModel product)
    //{
    //    var hasProduct = _productRepository.GetProductById(product.Id);

    //    if (hasProduct is null)
    //    {
    //        throw new ArgumentException($"Product with id {product.Id} does not exists!");
    //    }

    //    hasProduct.Name = product.Name;
    //    hasProduct.Code = product.Code;
    //    hasProduct.CategoryId = product.CategoryId;
    //    hasProduct.Description = product.Description;
    //    hasProduct.Price = product.Price;
    //    hasProduct.Stock = product.Stock;
    //    hasProduct.IsDeleted = product.IsDeleted;
    //    hasProduct.IsDisabled = product.IsDisabled;
    //    hasProduct.ModifyTime = DateTime.UtcNow;

    //    _productRepository.EditProduct(hasProduct);
    //    _productRepository.SaveSchanges();

    //    return true;
    //}
}