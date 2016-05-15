using System.Collections.Generic;

namespace DomainObjectModel.RepositoryInterfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
    }
}
