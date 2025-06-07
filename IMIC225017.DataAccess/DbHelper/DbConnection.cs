using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DbHelper
{
    public abstract class DbConnection<T>
    {
        public abstract T GetConnection();
    }
}
