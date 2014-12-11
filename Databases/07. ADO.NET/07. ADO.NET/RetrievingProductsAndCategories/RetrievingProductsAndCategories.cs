using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RetrievingProductsAndCategories
{
    class RetrievingProductsAndCategories
    {
        static void Main()
        {
            SqlConnection dbConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dbConnection.Open();

            using(dbConnection)
	        {
		        SqlCommand getProductsAndCategories = new SqlCommand("select c.CategoryName, p.ProductName from Categories c inner join Products p on c.CategoryID = p.CategoryID group by c.CategoryName, p.ProductName", dbConnection);

                SqlDataReader reader = getProductsAndCategories.ExecuteReader();
                using (reader)
                {
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
