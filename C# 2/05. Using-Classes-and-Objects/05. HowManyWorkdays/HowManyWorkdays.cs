//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class HowManyWorkdays
{
    static void Workdays(DateTime endDay)
        {
            DateTime[] holidays = {
                                        new DateTime(2013, 01, 1),
                                        new DateTime(2013, 03, 03),
                                        new DateTime(2013, 05, 01),
                                        new DateTime(2013, 05, 24),
                                        new DateTime(2013, 09, 06),
                                        new DateTime(2013, 09, 22),
                                        new DateTime(2013, 12, 24),
                                        new DateTime(2013, 12, 25),
                                        new DateTime(2013, 12, 26),
                                        new DateTime(2013, 12, 31),
                                  };

            DateTime today = DateTime.Today;
            int allDays = (endDay - today).Days;
            int workDays = allDays;

            while (today <= endDay)
            {
                if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
                {
                    workDays--;
                }
                else
                {
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (today == holidays[i])
                        {
                            workDays--;
                        }
                    }
                }
                today = today.AddDays(1);
            }
            Console.WriteLine("Workdays until then are: {0}", workDays);
        }

        static void Main()
        {
            Console.WriteLine("Enter the end date in YYYY/MM/DD format: ");
            DateTime endDay = DateTime.Parse(Console.ReadLine());
            Workdays(endDay);
        }
    }

