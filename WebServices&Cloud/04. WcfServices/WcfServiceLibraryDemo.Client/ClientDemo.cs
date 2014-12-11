namespace WcfServiceLibraryDemo.Client
{
    using System;
    using System.ServiceModel;

    public class ClientDemo
    {
        /* 05. Create a console client for the WCF service above. Use the svcutil.exe tool to generate the proxy classes.*/

        static void Main()
        {
            ServiceDayOfWeekClient client = new ServiceDayOfWeekClient();

            var dayInBg = client.GetDayOfWeek(DateTime.Now);

            Console.WriteLine("Днес е: {0}.", dayInBg);
        }
    }
}
