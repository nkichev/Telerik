using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //task2.Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers. Write a testing class.

            //Customers newCustomer = new Customers()
            //{
            //    CompanyName = "home",
            //    ContactName = "tosho",
            //    CustomerID = "94"
            //};

            //DAO.InsertCustomer(newCustomer);

            //Customers modifiedCustomer = new Customers()
            //{
            //    ContactName = "boiko",
            //};

            //DAO.ModifyCustomer("94", modifiedCustomer);

            //DAO.DeleteCustomer("94");

            ////-----------------------------------------------------------------------------------------------
            ////task3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

            //DAO.FindCustomersWithOrdersOn1997ToCanada();

            ////-----------------------------------------------------------------------------------------------
            ////task4.Implement previous by using native SQL query and executing it through the DbContext.

            //DAO.FindCustomersWithOrdersOn1997ToCanadaSQL();

            ////-----------------------------------------------------------------------------------------------
            ////task5.Write a method that finds all the sales by specified region and period (start / end dates).

            //DAO.FindSalesByRegionAndPeriod("CA", new DateTime(1995, 11, 15), new DateTime(1998, 11, 20));

            ////-----------------------------------------------------------------------------------------------
            //task6.Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext. Find for the API for schema generation in MSDN or in Google.

            //NorthwindEntities db = new NorthwindEntities();
            //string dbScript = db.CreateDatabaseScript();
            //dbScript = "CREATE DATABASE [NorthwindTwin] \n GO \nUSE [NorthwindTwin \n" + dbScript;

            //StreamWriter writer = new StreamWriter("CreateNorthwindTwinDB.sql");

            //using (writer)
            //{
            //    writer.WriteLine(dbScript);
            //}

            ////-----------------------------------------------------------------------------------------------
            //task10.Create a stored procedures in the Northwind database for finding the total incomes for given supplier name and period (start date, end date). Implement a C# method that calls the stored procedure and returns the retuned record set.

            //DAO.FindTotalIncome("Tokyo Traders", 1995, 1998);

            ////-----------------------------------------------------------------------------------------------
            //task7.Try to open two different data contexts and perform concurrent changes on the same records. What will happen at SaveChanges()? How to deal with it?

            //DAO.ExecuteTwoDBContexts();

            ////-----------------------------------------------------------------------------------------------
            //task8.By inheriting the Employee entity class create a class which allows employees to access their corresponding territories as property of type EntitySet<T>.

            //made new partial class Employees in DAO.cs where we use Territories. To be able to use EntitySet<TEntity> we need to add refference to System.Data.Linq.
            //more information on http://msdn.microsoft.com/en-us/library/bb341748%28v=vs.110%29.aspx

        }
    }
}
