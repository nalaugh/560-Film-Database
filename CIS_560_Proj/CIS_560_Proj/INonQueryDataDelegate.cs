using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Proj
{
    public interface INonQueryDataDelegate<out T> : IDataDelegate
    {
        T Translate(SqlCommand command);
    }
}
