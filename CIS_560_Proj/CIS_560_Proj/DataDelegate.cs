using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CIS_560_Proj
{
    public abstract class DataDelegate : IDataDelegate
    {
        public string ProcedureName { get; }

        protected DataDelegate(string procedureName)
        {
            if (string.IsNullOrWhiteSpace(procedureName))
                throw new ArgumentException("The procedure name cannot be null or empty.", nameof(procedureName));

            ProcedureName = procedureName;
        }

        public virtual void PrepareCommand(SqlCommand command)
        {
            command.CommandType = CommandType.StoredProcedure;
        }
    }
}
