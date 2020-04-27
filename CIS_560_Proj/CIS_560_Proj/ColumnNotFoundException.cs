using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Proj
{
    public class ColumnNotFoundException : Exception
    {
        public ColumnNotFoundException(string name, Exception innerException = null)
            : base($"The column [{name}] was not found in the result set.", innerException)
        {
        }
    }
    
    
}
