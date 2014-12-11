using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The salary must be positive number!");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        { 
            return (decimal) weekSalary / (workHoursPerDay * 5);
        }
    }
}
