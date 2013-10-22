using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public enum BatteryType
    { 
        LiIon,
        NiMH,
        NiCd,
        Standart,
    }

    class Battery
    {
        // Fields
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        // Properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (this.hoursIdle <= 0)
                {
                    throw new ArgumentException("Ivalid hours - idle input!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (this.hoursTalk <= 0)
                {
                    throw new ArgumentException("Ivalid hours - talk input!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Methods
        public override string ToString()
        {
            return string.Format("model {0}, hours - idle {1}, hours talk {2}, type {3}", this.Model, this.HoursIdle, this.HoursTalk, this.Type);
        }

        // Constructor
        public Battery(string model = null, double? hoursIdle = null, double? hoursTalk = null, BatteryType type = BatteryType.Standart)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }
    }
}
