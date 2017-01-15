using System;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Subtests
{
    public static class SpecFlowExtensions
    {
        public static string GetData(this Table myTable, string fieldName)
        {
            string returnValue = null;
            //Vertical table
            foreach (var row in myTable.Rows)
            {
                string[] child = new string[row.Values.Count];
                row.Values.CopyTo(child, 0);
                if (child[0] == fieldName)
                {
                    returnValue = child[1].Replace("\"", "");
                    break;
                }
            }

            if (returnValue == null)
            {
                throw new Exception("Error reading field: " + fieldName + " check its named correctly");
            }

            return returnValue;
        }

        /// <summary>
        /// Returns the Data for the Value field based on the row index
        /// </summary>
        /// <param name="myTable"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string GetData(this Table myTable, int index)
        {
            string returnValue = null;
            int counter = 0;
            //Vertical table
            foreach (var row in myTable.Rows)
            {
                string[] child = new string[row.Values.Count];
                row.Values.CopyTo(child, 0);
                if (counter == index)
                {
                    returnValue = child[1].Replace("\"", "");
                    break;
                }

                counter++;
            }

            if (returnValue == null)
            {
                throw new Exception("Error reading field from index: " + index + " check its indexed correctly");
            }

            return returnValue;
        }

        /// <summary>
        /// Returns the table cell data based on the rowindex and columnindex
        /// </summary>
        /// <param name="myTable"></param>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public static string GetData(this Table myTable, int rowIndex, int columnIndex)
        {
            string returnValue = null;
            int counter = 0;
            //Vertical table
            foreach (var row in myTable.Rows)
            {
                string[] child = new string[row.Values.Count];
                row.Values.CopyTo(child, 0);
                if (counter == rowIndex)
                {
                    returnValue = child[columnIndex].Replace("\"", "");
                    break;
                }

                counter++;
            }

            if (returnValue == null)
            {
                throw new Exception("Error reading field from Row Index: " + rowIndex + " and Column Index: " + columnIndex + " check they are indexed correctly");
            }

            return returnValue;
        }

        /// <summary>
        /// Return the value of a cell in the table based on the column name and the row index
        /// </summary>
        /// <param name="myTable"></param>
        /// <param name="columnName"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public static string GetData(this Table myTable, string columnName, int rowIndex)
        {
            string returnValue = null;

            int columnIndex = 0;

            var myRow = myTable.Rows[0];
            string[] columns = new string[myRow.Keys.Count];
            myRow.Keys.CopyTo(columns, 0);

            //Find what index the column is in
            for (int i = 0; i < columns.Length; i++)
            {
                if (columns[i] == columnName)
                {
                    columnIndex = i;
                }
            }

            string[] child = new string[myTable.Rows[rowIndex].Values.Count];
            myTable.Rows[rowIndex].Values.CopyTo(child, 0);

            returnValue = child[columnIndex].Replace("\"", ""); ;

            if (returnValue == null)
            {
                throw new Exception("Error reading field from Row Index: " + rowIndex + " and Column Name: " + columnName + " check they are indexed correctly");
            }

            return returnValue;
        }

        public static string GetData(this Table myTable, string primaryColumn, string primaryColumnValue, string queryColumn)
        {
            int primaryColIndex = 0;
            int queryColIndex = 0;
            string returnValue = "";

            var myRow = myTable.Rows[1];
            string[] columns = new string[myRow.Keys.Count];
            myRow.Keys.CopyTo(columns, 0);

            for (int i = 0; i < columns.Length; i++)
            {
                if (columns[i] == primaryColumn)
                {
                    primaryColIndex = i;
                }
                if (columns[i] == queryColumn)
                {
                    queryColIndex = i;
                }
            }

            foreach (var row in myTable.Rows)
            {
                string[] child = new string[row.Values.Count];
                row.Values.CopyTo(child, 0);
                if (child[primaryColIndex] == primaryColumnValue)
                {
                    returnValue = child[queryColIndex];
                    break;
                }
            }

            return returnValue;
        }
    }
}