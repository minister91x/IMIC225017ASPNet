using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccessNetCore.IRespository
{
    public interface ICategoryRepository
    {
        Task<List<DataAccessNetCore.DataObject.Category>> CategoryGetList();
        Task<DataAccessNetCore.DataObject.Category> CategoryGetByID(int CategoryID);
    }
}
