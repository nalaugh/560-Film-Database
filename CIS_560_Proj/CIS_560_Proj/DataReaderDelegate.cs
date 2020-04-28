
using System.Data.SqlClient;

namespace CIS_560_Proj
{

    public abstract class DataReaderDelegate<T> : DataDelegate, IDataReaderDelegate<T>
    {
        protected DataReaderDelegate(string procedureName)
           : base(procedureName)
        {
        }

        public abstract T Translate(SqlCommand command, IDataRowReader reader);
    }

}
