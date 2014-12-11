namespace RetrievingDataFromMySQLDB
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MySql.Data.MySqlClient;

    class RetrievingDataFromMySQLDB
    {
        static void CreateDB(MySqlConnection connection)
        {
            StreamReader sqlScript = new StreamReader("../../BooksDBScript.sql");
            MySqlCommand createDB = new MySqlCommand(sqlScript.ReadToEnd(), connection);
            createDB.ExecuteNonQuery();
            Console.WriteLine("Database Books is created.");
        }

        static void InsertBook(MySqlConnection connection, string author, string title, string ISBN, string publishDate)
        {
            string insertSql = @"use Books; insert into BOOKS(ISBN, Title, Author, PublishDate) values(@ISBN, @Title, @Author, @PublishDate)";
            MySqlCommand insertBook = new MySqlCommand(insertSql, connection);
            insertBook.Parameters.AddWithValue("@ISBN", ISBN);
            insertBook.Parameters.AddWithValue("@Title", title);
            insertBook.Parameters.AddWithValue("@Author", author);
            insertBook.Parameters.AddWithValue("@PublishDate", publishDate);
            insertBook.ExecuteNonQuery();
            Console.WriteLine("The book is inserted successfully.");
        }

        static void ListAllBooks(MySqlConnection connection)
        {
            string insertSql = @"use Books; select ISBN, Title, Author, PublishDate from Books";
            MySqlCommand insertBook = new MySqlCommand(insertSql, connection);

            using (MySqlDataReader reader = insertBook.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} | {1} | {2} | {3}", reader[0], reader[1], reader[2], reader[3]);
                }
            }
        }

        static void FindBookByName(MySqlConnection connection, string title)
        {
            string insertSql = @"use Books; select ISBN, Title, Author, PublishDate from Books where Title like @bookName";
            MySqlCommand insertBook = new MySqlCommand(insertSql, connection);
            insertBook.Parameters.AddWithValue("@bookName", "%" + title + "%");
            Console.WriteLine(insertSql);

            using (MySqlDataReader reader = insertBook.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} | {1} | {2} | {3}", reader[0], reader[1], reader[2], reader[3]);
                }
            }
        }

        static void Main(string[] args)
        {
            string connToMySql = @"Server=localhost;Uid=root;Pwd=root;Allow User Variables=True;";
            MySqlConnection connect = new MySqlConnection(connToMySql);
            connect.Open();

            using (connect)
            {
                CreateDB(connect);

                InsertBook(connect, "Ivan Vazov", "Pod igoto", "41124114512125512X", "1894, 01, 01");
                InsertBook(connect, "Emilian Stanev", "Kradetsat na praskovi", "411124114512125512X", "1948, 01, 01");
                InsertBook(connect, "Ivan Vazov", "Na proshtavane", "4112411451212512X", "1871, 06, 25,");
                ListAllBooks(connect);
                Console.Write("Enter a search word:");
                string searchString = Console.ReadLine().Replace("%", "[%]")
                .Replace("_", "[_]");
                Console.WriteLine();
                FindBookByName(connect, searchString);
            }
        }
    }
}
