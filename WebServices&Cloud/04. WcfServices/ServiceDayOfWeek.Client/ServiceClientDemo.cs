namespace ServiceDayOfWeek.Client
{
    using System;
    using ServiceDayOfWeek.Client.ServiceDayOfWeekReference;

    public class ServiceClientDemo
    {
        /* 02. Create a console-based client for the WCF service above. 
         * Use the "Add Service Reference" in Visual Studio.*/

        static void Main()
        {
            ServiceDayOfWeekClient client = new ServiceDayOfWeekClient();

            var dayInBg = client.GetDayOfWeek(DateTime.Now);

            Console.WriteLine("Днес е: {0}.", dayInBg);
        }
    }
}
