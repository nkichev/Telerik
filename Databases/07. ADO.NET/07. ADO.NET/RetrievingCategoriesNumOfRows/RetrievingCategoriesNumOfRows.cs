namespace RetrievingCategoriesNumOfRows
{
    using System;
    using System.Data.SqlClient;

    public class RetrievingCategoriesNumOfRows
    {
        //Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.

        static void Main()
        {
            SqlConnection dbConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand getCategoriesNumOfRows = new SqlCommand("select count(*) from Categories", dbConnection);
                int numOfRows = (int)getCategoriesNumOfRows.ExecuteScalar();
                Console.WriteLine("Categories number of rows: " + numOfRows);
            }
        }
    }
}
