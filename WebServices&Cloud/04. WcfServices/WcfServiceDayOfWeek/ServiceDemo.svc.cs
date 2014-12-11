namespace WcfServiceDayOfWeek
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class ServiceDemo : IServiceDayOfWeek
    {
        /*01. Create a simple WCF service. It should have a method that accepts a DateTime parameter and returns the day of week (in Bulgarian) as string. 
         * Test it with the integrated WCF client.*/

        public string GetDayOfWeek(DateTime date)
        {
            var cultureInfo = new CultureInfo("bg-BG");
            var dayNum = (int)date.DayOfWeek;
            var dayOfWeekInBg = cultureInfo.DateTimeFormat.DayNames[dayNum];

            return dayOfWeekInBg;
        }
    }
}
