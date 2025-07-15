using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccessNetCore.DataObject;
using IMIC225017.DataAccessNetCore.DbContext;
using IMIC225017.DataAccessNetCore.IRespository;
using Microsoft.EntityFrameworkCore;

namespace IMIC225017.DataAccessNetCore.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IMIC072250DbContext _dbContext;
        public ProductRepository(IMIC072250DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Product> ProductGetById(int id)
        {
            return _dbContext.product
                .Where(s => s.ProductID == id)
                .FirstOrDefaultAsync();
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

            // Check trùng
            var isDuplicate = _dbContext.product.ToList().FindAll(s => s.ProductName == product.ProductName).Any();

            if (isDuplicate)
            {
                return -1;
            }


            product.created_at = DateTime.Now;

            _dbContext.product.Add(product);
            return _dbContext.SaveChanges();
        }

        public async Task<int> ProductUpdate(Product product)
        {
            var productCurr = _dbContext.product.Where(s => s.ProductID == product.ProductID).FirstOrDefault();

            if(productCurr==null || productCurr.ProductID<=0)
            {
                return -1;
            }

            productCurr.ProductName = product.ProductName;
            productCurr.Description = product.Description;

            _dbContext.product.Update(productCurr);
            return _dbContext.SaveChanges();

        }

        public async Task<int> Product_Delete(int id)
        {
            var productCurr = _dbContext.product.Where(s => s.ProductID == id).FirstOrDefault();

            if (productCurr == null || productCurr.ProductID <= 0)
            {
                return -1;
            }

            _dbContext.product.Remove(productCurr);
            return _dbContext.SaveChanges();
        }
    }
}
