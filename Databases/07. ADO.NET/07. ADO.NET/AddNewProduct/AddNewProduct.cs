namespace AddNewProduct
{
    using System;
    using System.Data.SqlClient;

    class AddNewProduct
    {
        //Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.

        static void Main()
        {
            SqlConnection dbConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dbConnection.Open();

            using (dbConnection)
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@productToAdd";
                param.Value = "coffee";

                SqlCommand addProductCommand = new SqlCommand("insert into Products (ProductName) values (@productToAdd)", dbConnection);
                addProductCommand.Parameters.Add(param);

                int rows = addProductCommand.ExecuteNonQuery();
                if (rows == 1)
                {
                    Console.WriteLine("Product added.");
                }
            }
        }
    }
}

