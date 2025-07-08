using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccessNetCore.DataObject;

namespace IMIC225017.DataAccessNetCore.IRespository
{
    public interface IProductRepository
    {
        Task<List<Product>> ProductGetList(ProductGetListRequestData requestData);
        Task<int> ProductInsert(Product product);
    }
}
