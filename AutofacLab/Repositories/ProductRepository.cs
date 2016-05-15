using DomainObjectModel;
using DomainObjectModel.RepositoryInterfaces;
using System.Collections.Generic;
using System.Data;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public static IDbConnection _productsDbConnection;

        public ProductRepository(IDbConnection dbConnection)
        {
            _productsDbConnection = dbConnection;
        }

        List<Product> IProductRepository.GetAllProducts()
        {
            List<Product> productsList = new List<Product>();



            return productsList;
        }
    }
}
