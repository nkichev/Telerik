namespace RetrievingCategoriesNamAndDescription
{
    using System;
    using System.Data.SqlClient;

    class RetrievingCategoriesNamAndDescription
    {
        //Write a program that retrieves the name and description of all categories in the Northwind DB.

        static void Main()
        {
            SqlConnection dbConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand getCategoriesNameAndDescription = new SqlCommand("select CategoryName, Description from Categories", dbConnection);

                SqlDataReader reader = getCategoriesNameAndDescription.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine(categoryName + ": " + description);
                    }
                }
            }
        }
    }
}