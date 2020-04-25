using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Proj
{
    internal class DataRowReader : IDataRowReader
    {
        private readonly SqlDataReader reader;

        public DataRowReader(SqlDataReader reader)
        {
            this.reader = reader;
        }

        public bool Read()
        {
            return reader.Read();
        }

        public int GetInt32(string name)
        {
            return GetValue(name, reader.GetInt32);
        }

        public byte GetByte(string name)
        {
            return GetValue(name, reader.GetByte);
        }

        public bool GetBoolean(string name)
        {
            return GetValue(name, reader.GetBoolean);
        }

        public string GetString(string name)
        {
            return GetValue(name, reader.GetString);
        }

        public DateTimeOffset GetDateTimeOffset(string name)
        {
            return GetValue(name, reader.GetDateTimeOffset);
        }

        public T GetValue<T>(string name)
        {
            return (T)reader.GetValue(reader.GetOrdinal(name));
        }

        public T GetValue<T>(string name, Func<int, T> getter)
        {
            try
            {
                return getter(reader.GetOrdinal(name));
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new ColumnNotFoundException(name, ex);
            }
        }
    }
}
