using Shop.Core.DomainEntities;

namespace Shop.Core.Business.Interfaces;

    public interface IProductService
    {
        public Product GetProductById(int id);

        public List<Product> GetAllProducts();
        public void AddProduct(Product productModel);
        public void EditProduct(int id, Product productModel);
        public void DeleteProduct(int id);

    }

