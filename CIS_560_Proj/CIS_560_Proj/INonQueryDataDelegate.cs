using System.Data.SqlClient;


namespace CIS_560_Proj
{
    public interface INonQueryDataDelegate<out T> : IDataDelegate
    {
        T Translate(SqlCommand command);
    }
}
