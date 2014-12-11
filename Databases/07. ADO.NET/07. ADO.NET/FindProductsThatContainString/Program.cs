using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FindProductsThatContainString
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dbConnection.Open();

            string str = Console.ReadLine().Replace("%", "[%]").Replace("_", "[_]");

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("SELECT c.CategoryName, p.ProductName FROM Products p " + 
                    " JOIN Categories c ON c.CategoryID = p.CategoryID " + 
                    " WHERE p.ProductName LIKE @str ORDER BY c.CategoryName", dbConnection);

                command.Parameters.AddWithValue("@str", "%" + str + "%");
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    Console.WriteLine("Category  |  Product ");
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];

                        Console.WriteLine(categoryName + ": " + productName);
                    }
                }
            }
        }
    }
}
