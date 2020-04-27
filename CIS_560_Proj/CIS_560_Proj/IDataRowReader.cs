using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Proj
{
    public interface IDataRowReader
    {
        bool Read();
        byte GetByte(string name);
        DateTimeOffset GetDateTimeOffset(string name);
        int GetInt32(string name);
        string GetString(string name);
        T GetValue<T>(string name);
    }
}
