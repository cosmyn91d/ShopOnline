using Shop.Core.Business.Interfaces;

namespace Shop.Core.Business
{
    public class ProductService : IProductService
    {

        public ProductView GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }
        public void AddProduct(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(int id, ProductModel productModel)
        {
            throw new NotImplementedException();
        }

    }
}
