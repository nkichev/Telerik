using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendRowsToExcel
{
    class AppendRowsToExcel
    {
        //Implement appending new rows to the Excel file.
        private static void AppendRowToExcel(OleDbConnection excelConnection, string name, double score)
        {
            OleDbCommand appendRow = new OleDbCommand("insert into [Sheet1$] (Name, Score) values (@name, @score)", excelConnection);
            appendRow.Parameters.AddWithValue("@name", name);
            appendRow.Parameters.AddWithValue("@score", score);
            appendRow.ExecuteNonQuery();
        }

        static void Main()
        {
            string filePath = @"../../table.xlsx";
            string provider = "Microsoft.ACE.OLEDB.12.0";
            string properties = "Excel 12.0;HDR=Yes;IMEX=2";
            string connectionString = String.Format("Provider = {0}; Data Source={1}; Extended Properties = \"{2}\"", provider, filePath, properties);
            OleDbConnection excelConnection = new OleDbConnection(connectionString);
            excelConnection.Open();

            using (excelConnection)
            {
                AppendRowToExcel(excelConnection, "Gosho", 15);
                Console.WriteLine("Inserted.");
            }
        }
    }
}
