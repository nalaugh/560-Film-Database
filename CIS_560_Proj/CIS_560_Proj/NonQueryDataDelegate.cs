using System.Data.SqlClient;


namespace CIS_560_Proj
{

    public abstract class NonQueryDataDelegate<T> : DataDelegate, INonQueryDataDelegate<T>
    {
        protected NonQueryDataDelegate(string procedureName)
           : base(procedureName)
        {
        }

        public abstract T Translate(SqlCommand command);
    }

}
