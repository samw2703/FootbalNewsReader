using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace FootbalNewsReader
{
    public static class SqlQueryBuilder
    {
        public static string BuildSelectStatement(string tableName, List<DatabaseProperty> properties)
        {
            string columnsString = string.Empty;
            foreach (var property in properties)
            {
                columnsString += property.ColumnName + ", ";
            }
            columnsString = columnsString.RemoveLast(2);

            return "SELECT " + columnsString + " FROM " + tableName;
        }

        public static string BuildSelectStatement(string tableName, List<string> columns)
        {
            string columnsString = string.Empty;
            foreach (var column in columns)
            {
                columnsString += column + ", ";
            }
            columnsString.RemoveLast(2);

            return "SELECT " + columnsString + " FROM " + tableName;
        }

        public static string BuildInsertIntoStatement(string tableName, List<DatabaseProperty> properties)
        {
            string columnsString = string.Empty;
            string valuesString = string.Empty;
            foreach (var property in properties)
            {
                columnsString += property.ColumnName + ", ";
                valuesString += property.PrintValueInSqlStatement() + ", ";
            }
            columnsString = columnsString.RemoveLast(2);
            valuesString = valuesString.RemoveLast(2);

            return "INSERT INTO " + tableName +
                " (" + columnsString + ") VALUES (" + valuesString + ")";
        }

        public static string BuildUpdateStatement(string tableName, List<DatabaseProperty> properties, List<DatabaseProperty> primaryKeyProperties)
        {
            string setString = string.Empty;
            string whereString = string.Empty;

            foreach (var property in properties)
            {
                setString += property.ColumnName + " = " + property.PrintValueInSqlStatement() + ", ";
            }
            setString = setString.RemoveLast(2);

            foreach (var primaryKeyProperty in primaryKeyProperties)
            {
                whereString += "(" + primaryKeyProperty.ColumnName + " = " + primaryKeyProperty.PrintValueInSqlStatement() + ") AND ";
            }
            whereString = whereString.RemoveLast(5);

            return "UPDATE " + tableName + " SET " + setString + " WHERE " + whereString;
        }

        public static string BuildDeleteStatement(string tableName, List<DatabaseProperty> primaryKeyProperties)
        {
            string whereString = string.Empty;

            foreach (var property in primaryKeyProperties)
            {
                whereString += whereString += "(" + property.ColumnName + " = " + property.PrintValueInSqlStatement() + ") AND ";
            }
            whereString = whereString.RemoveLast(5);

            return "DELETE FROM " + tableName + " WHERE " + whereString; 
        }
    }
}
