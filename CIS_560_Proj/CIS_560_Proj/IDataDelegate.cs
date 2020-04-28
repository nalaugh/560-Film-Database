using System.Data.SqlClient;

namespace CIS_560_Proj
{
    public interface IDataDelegate
    {
        string ProcedureName { get; }

        void PrepareCommand(SqlCommand command);
    }
}
