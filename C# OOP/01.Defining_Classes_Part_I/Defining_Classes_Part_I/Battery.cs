using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{


    public enum BatteryType
    {
        Li_Ion, NiMH, NiCd
    }

    public class Battery
    {
        //Properties
        public string Model { get; set; }
        public int HoursIdle { get; set; }
        public int HoursTalk { get; set; }
        private BatteryType type;

        public BatteryType Type
        {
            get { return this.type; }
        }

        //Constructors
        public Battery()
        {
        }
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.type = type;
        }
    }
}