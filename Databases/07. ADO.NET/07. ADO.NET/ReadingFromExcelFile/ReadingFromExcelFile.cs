namespace ReadingFromExcelFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;

    class ReadingFromExcelFile
    {
        //Create an Excel file with 2 columns: name and score:
        //Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row by row.
        //To be able to use excel files we need driver for this, you can find it here: http://www.microsoft.com/en-us/download/confirmation.aspx?id=23734

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

                OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", excelConnection);
                OleDbDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        double score = (double)reader["Score"];
                        Console.WriteLine(name + ": " + score);
                    }
                }
            }
        }
    }
}