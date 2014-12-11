using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InvalidRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = ReadInteger(1, 10000);
                Console.WriteLine("Your number: " + number);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0}\nRange: [{1}...{2}]", ex.Message, ex.StartRange, ex.EndRange);
            }

            try
            {
                DateTime date = ReadInteger(new DateTime(1900, 1, 1), new DateTime(2013, 12, 31));
                Console.WriteLine("Your date: " + date.ToString("dd.MM.yyyy"));
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0}\nRange: [{1}...{2}]", ex.Message, ex.StartRange, ex.EndRange);
            }            
        }

        static int ReadInteger(int start, int end)
        {
            int number;
            do
            {
                Console.WriteLine("Insert number at interval [{0} ... {1}]", start, end);
            } while (!int.TryParse(Console.ReadLine(), out number));
            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>(start, end, String.Format("Number is out of range[{0} ... {1}]", start, end));
            }
            else
            {
                return number;
            }
        }

        static DateTime ReadInteger(DateTime start, DateTime end)
        {
            DateTime date;
            do
            {
                Console.WriteLine("Insert date (day/month/year)at interval [{0} ... {1}]", start.ToString("dd.MM.yyyy"), end.ToString("dd.MM.yyyy"));
            } while (!DateTime.TryParseExact(Console.ReadLine(), new string[] { "d/M/yyyy", "dd/MM/yyyy", "d/M/yy", "dd/MM/yy", "d.M.yyyy", "dd.MM.yyyy", "d.M.yy", "dd.MM.yy", }, CultureInfo.InvariantCulture, DateTimeStyles.None, out date));
            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>(start, end, String.Format("Number is out of range[{0} ... {1}]", start, end));
            }
            else
            {
                return date;
            }
        }
    }
}
