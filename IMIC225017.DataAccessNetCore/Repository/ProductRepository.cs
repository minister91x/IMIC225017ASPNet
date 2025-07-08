using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccessNetCore.DataObject;
using IMIC225017.DataAccessNetCore.DbContext;
using IMIC225017.DataAccessNetCore.IRespository;

namespace IMIC225017.DataAccessNetCore.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IMIC072250DbContext _dbContext;
        public ProductRepository(IMIC072250DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Product>> ProductGetList(ProductGetListRequestData requestData)
        {
            try
            {
                return _dbContext.product.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<int> ProductInsert(Product product)
        {
            product.created_at = DateTime.Now;
            _dbContext.product.Add(product);
            return _dbContext.SaveChanges();
        }
    }
}
