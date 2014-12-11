namespace RetrievingCategoriesImages
{
    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;

    class RetrievingCategoriesImages
    {
        //Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.

        static void Main()
        {
            SqlConnection dbConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand getImages = new SqlCommand("select CategoryName, Picture from Categories", dbConnection);

                SqlDataReader reader = getImages.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        if (categoryName.Contains("/") == true)
                        {
                            categoryName = categoryName.Replace('/', ' ');
                        }

                        byte[] pictureBytes = reader["Picture"] as byte[];

                        MemoryStream stream = new MemoryStream(pictureBytes, 78, pictureBytes.Length - 78);
                        Image picture = Image.FromStream(stream);
                        using (picture)
                        {
                            picture.Save(categoryName + ".jpg", ImageFormat.Jpeg);
                            //saved to : \RetrievingCategoriesImages\bin\Debugx
                        }

                        Console.WriteLine("Pictures retrieved successfully.");
                    }
                }
            }
        }
    }
}