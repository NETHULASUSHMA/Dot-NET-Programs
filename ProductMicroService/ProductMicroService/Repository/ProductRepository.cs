using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ProductMicroService.DBContexts;
using ProductMicroService.Models;
using ProductMicroService.Models;

namespace ProductMicroService.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteProduct(Product Product)
        {
            // throw new NotImplementedException();
            var product = _dbContext.Products.Find(Product);
            _dbContext.Products.Remove(product);
            Save();

        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPproducts()
        {
            //throw new NotImplementedException();
            return _dbContext.Products.ToList();
        }

        public Product GetProductByID(int ProductId)
        {
            //throw new NotImplementedException();
            return _dbContext.Products.Find(ProductId);
        }

        public IEnumerable<Product> GetProducts()
        {
            // throw new NotImplementedException();
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product Product)
        {
            //throw new NotImplementedException();
            _dbContext.Add(Product);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void UpdateProduct(Product Product)
        {
            //throw new NotImplementedException();
            _dbContext.Entry(Product).State = EntityState.Modified;
            Save();
        }
    }
}
