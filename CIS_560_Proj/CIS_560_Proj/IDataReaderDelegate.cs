using System.Data.SqlClient;

namespace CIS_560_Proj
{
    public interface IDataReaderDelegate<out T> : IDataDelegate
    {
        T Translate(SqlCommand command, IDataRowReader reader);
    }
}
