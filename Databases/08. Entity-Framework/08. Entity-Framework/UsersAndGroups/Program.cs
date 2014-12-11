namespace UsersAndGroups
{
    using System;
    using System.Linq;
    using System.Transactions;

    class Program
    {
        static void Main(string[] args)
        {
            var user = new Users 
            {
                UserName = "Bat Ivan"
            };

            using (var db = new UsersAndGroupsEntities())
            {
                using (TransactionScope transaction = new TransactionScope())
                {
                    var userGoup = db.Groups.FirstOrDefault(g => g.GroupName == "Admins");
                    if (userGoup == null)
                    {
                        db.Groups.Add(new Groups { GroupName = "Admins" });
                        db.SaveChanges();
                    }

                    var adminGroup = db.Groups.First(g => g.GroupName == "Admins");
                    user.GroupID = adminGroup.GroupID;

                    db.Users.Add(user);
                    db.SaveChanges();
                    transaction.Complete();
                }
            }
        }
    }
}
