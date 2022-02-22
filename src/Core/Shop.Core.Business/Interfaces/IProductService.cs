using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Business.Interfaces
{
    public interface IProductService
    {
        public ProductView GetProductById(int id);
        public List<Product> GetAllProducts();
        public void AddProduct(ProductModel productModel);
        public void EditProduct(int id, ProductModel productModel);
        public void DeleteProduct(int id);


    }
}
