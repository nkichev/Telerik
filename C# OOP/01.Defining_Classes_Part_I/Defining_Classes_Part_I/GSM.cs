using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{
    public class GSM
    {
        //Fields
        private Battery battery = new Battery();
        private Display display = new Display();
        private static GSM iPhone4S;
        private List<Call> callHistory;

        //Properties
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public string Owner { get; set; }
        public Battery GsmBattery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display GsmDisplay
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        //Constructors
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        //Methods
        public void AddingCalls(Call call)
        {
            if (callHistory == null)
            {
                callHistory = new List<Call>();
            }
            callHistory.Add(call);
        }

        public void AddingCalls(int index, Call call)
        {
            if (callHistory == null)
            {
                callHistory = new List<Call>();
            }
            if (index < callHistory.Count)
            {
                callHistory.Insert(index, call);
            }
            else
            {
                callHistory.Add(call);
            }
        }
        public void RemovingCalls(int index)
        {
            if (index < callHistory.Count)
            {
                this.callHistory.RemoveAt(index);
            }
        }
        public void ClearCalls()
        {
            this.callHistory.Clear();
        }
        public double CalcTotalPrice(double pricePerMinute)
        {
            double result = 0;
            foreach (var item in callHistory)
            {
                result += (item.Duration / 60) * pricePerMinute;
            }

            return result;
        }


        public override string ToString()
        {
            string result = String.Format("Your GSM charackteristics are:\nmodel : {0}\nmanufacturer : {1}", this.Model, this.Manufacturer);

            if (this.Price == 0)
            {
                result += "\nprise : no info";
            }
            else
            {
                result += "\nprise : " + this.Price;
            }
            if (this.Owner == null)
            {
                result += "\nowner : no info";
            }
            else
            {
                result += "\nowner : " + this.Owner;
            }
            if (this.battery.Model == null)
            {
                result += "\nBattery - model : no info";
            }
            else
            {
                result += "\nBattery - model : " + this.battery.Model;
            }
            if (this.battery.HoursIdle == 0)
            {
                result += "; hoursIdle : no info";
            }
            else
            {
                result += "; hoursIdle : " + this.battery.HoursIdle;
            }
            if (this.battery.HoursTalk == 0)
            {
                result += "; hoursTalk : no info";
            }
            else
            {
                result += "; hoursTalk : " + this.battery.HoursTalk;
            }
            if (this.battery.Type == 0)
            {
                result += "; type : no info";
            }
            else
            {
                result += "; type : " + this.battery.Type;
            }
            if (this.display.Size == 0)
            {
                result += "\nDisplay - size : no info";
            }
            else
            {
                result += "\nDisplay - size : " + this.display.Size;
            }
            if (this.display.NumberofColors == 0)
            {
                result += "; numberofColors : no info";
            }
            else
            {
                result += "; numberofColors : " + this.display.NumberofColors;
            }

            return result;
        }
    }
}