using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace FootbalNewsReader
{
    public enum SqlDataType { sqlInt, sqlVarchar, sqlDatetime };

    public class DatabaseProperty
    {
        private SqlDataType _sqlDataType;

        public string ColumnName { get; set; }
        public string Value { get; set; }

        public DatabaseProperty(string columnName, SqlDataType sqlDataType)
        {
            ColumnName = columnName;
            _sqlDataType = sqlDataType;
        }

        public DatabaseProperty(string columnName, SqlDataType sqlDataType, string value)
        {
            ColumnName = columnName;
            _sqlDataType = sqlDataType;
            Value = value;
        }

        public DatabaseProperty(DatabasePropertyShell databasePropertyShell)
        {
            ColumnName = databasePropertyShell.ColumnName;
            _sqlDataType = databasePropertyShell.DataType;
        }

        public DatabaseProperty(DatabasePropertyShell databasePropertyShell, string value)
        {
            ColumnName = databasePropertyShell.ColumnName;
            _sqlDataType = databasePropertyShell.DataType;
            Value = value;
        }

        public string PrintValueInSqlStatement()
        {
            if (_sqlDataType.Equals(SqlDataType.sqlInt))
                return Value;

            return Value.SingleQuotedString();
        }
    }
}
