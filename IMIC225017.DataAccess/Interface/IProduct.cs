using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccess.DataObject;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Finance.Implementations;

namespace IMIC225017.DataAccess.Interface
{
    public interface IProduct
    {
        List<ProductGetList_ResponseData> ProductGetList(ProductGetListRequestData requestData,out int totalRecords);
        ProductInsertResponseData ProductInsert(Product product);

        ProductDeleteResponseData ProductDelete(List<int> ProductIDs);
    }
}
