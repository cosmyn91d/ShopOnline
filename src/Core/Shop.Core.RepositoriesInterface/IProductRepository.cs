using Shop.Core.DomainEntities;

namespace Shop.Core.RepositoriesInterface;
public interface IRepository<T> where T : EntityBase
{
    public T? GetById(int id);
    public IEnumerable<T> GetAll();
    public int Add(T product);
    int Update(T productModel);
}

public interface IProductRepository: IRepository<Product>
{
    Product? GetProductByName(string name);
}

