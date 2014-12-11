using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.Data.Objects;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace NorthwindDB
{
    public class DAO
    {
        public static void InsertCustomer(Customers newCustomer) 
        {
            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(newCustomer);
                db.SaveChanges();
                Console.WriteLine("Inserted successfully.");
            }
        }

        public static void DeleteCustomer(string id)
        {
            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers.Where(c => c.CustomerID == id).FirstOrDefault();
                db.Customers.Remove(customer);
                db.SaveChanges();
                Console.WriteLine("Deleted successfully.");
            }
        }

        public static void ModifyCustomer(string id, Customers modifiedCustomer)
        {
            using(var db = new NorthwindEntities())
            {
                var customer = db.Customers.Where(c => c.CustomerID == modifiedCustomer.CustomerID).FirstOrDefault();
                customer = modifiedCustomer;
                db.SaveChanges();
                Console.WriteLine("Modified successfully.");
            }
        }

        public static void FindCustomersWithOrdersOn1997ToCanada()
        {
            using (var db = new NorthwindEntities())
            {
                var orders = db.Orders
                    .Where(o => o.OrderDate.Value.Year == 1997)
                    .Where(o => o.ShipCountry == "Canada");

                foreach (var order in orders)
                {
                    Console.WriteLine("Order N{0} to {1}, made in 1997 to Canada.", order.OrderID, order.Customers.ContactName);
                }
            };
        }

        public static void FindCustomersWithOrdersOn1997ToCanadaSQL()
        {
            using (var db = new NorthwindEntities())
            {
                string query = @"SELECT c.ContactName from Customers" +
                                  " c INNER JOIN Orders o ON o.CustomerID = c.CustomerID " +
                                  "WHERE (YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada');";

                var queryResult = db.Database.SqlQuery<string>(query);

                foreach (var name in queryResult)
                {
                    Console.WriteLine(name);
                }
            }
        }

        public static void FindSalesByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            using (var db = new NorthwindEntities())
            {
                var orders = db.Orders
                    .Where(o => o.ShipRegion == region && o.OrderDate >= startDate && o.ShippedDate <= endDate);

                foreach (var order in orders)
                {
                    Console.WriteLine(order.OrderID);
                }
            }
        }

        public static void FindTotalIncome(string companyName, int startYear, int endYear)
        {
            using (var db = new NorthwindEntities())
            {
                var income = db.usp_TotalIncome(companyName, startYear, endYear);
                Console.WriteLine("Total income is {0}", income.FirstOrDefault());
            }
        }

        public static void ExecuteTwoDBContexts()
        {
            var firstDB = new NorthwindEntities();
            var secondDB = new NorthwindEntities();

            var customer1 = firstDB.Customers.Where(c => c.CustomerID == "94").FirstOrDefault();
            customer1.ContactName = "kiki";

            var customer2 = secondDB.Customers.Where(c => c.CustomerID == "94").FirstOrDefault();
            customer2.ContactName = "kiki";

            firstDB.SaveChanges();
            secondDB.SaveChanges();
        }
    }

    public partial class Employees
    {
        private EntitySet<Territories> entityTerritories;

        public EntitySet<Territories> EntityTerritories 
        {
            get
            {
                var employeeTerritories = this.Territories;
                entityTerritories = new EntitySet<Territories>();
                entityTerritories.AddRange(employeeTerritories);
                return entityTerritories;
            }
        }
    }
}
