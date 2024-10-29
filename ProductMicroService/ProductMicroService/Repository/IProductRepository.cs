//using ProductMicroService.Model;
using ProductMicroService.Models;
using System.Collections.Generic;

namespace ProductMicroService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product Product);
        void DeleteProduct(int id);
        void UpdateProduct(Product Product);
        void Save();

    }
}
