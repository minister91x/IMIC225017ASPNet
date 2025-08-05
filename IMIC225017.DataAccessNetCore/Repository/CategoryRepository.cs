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
    public class CategoryRepository : ICategoryRepository
    {
        public IMIC072250DbContext _dbContext;
        public CategoryRepository(IMIC072250DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Category> CategoryGetByID(int CategoryID)
        {
            return await _dbContext.category
                .Where(s => s.CategoryID == CategoryID)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Category>> CategoryGetList()
        {
            return await _dbContext.category
                .ToListAsync();
        }
    }
}
