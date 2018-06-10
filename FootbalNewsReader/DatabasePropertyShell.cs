using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalNewsReader
{
    public class DatabasePropertyShell
    {
        public SqlDataType DataType { get; }
        public string ColumnName { get; set; }

        public DatabasePropertyShell(string columnName, SqlDataType sqlDataType)
        {
            ColumnName = columnName;
            DataType = sqlDataType;
        }
    }
}
