using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            //System.DateTime date1 = new System.DateTime(1996, 6, 3, 22, 15, 0);
			//System.DateTime date2 = new System.DateTime(1996, 12, 6, 13, 2, 0);
			//System.DateTime date3 = new System.DateTime(1996, 10, 12, 8, 42, 0);
            //
			//// diff1 gets 185 days, 14 hours, and 47 minutes.
			//System.TimeSpan diff1 = date2.Subtract(date1);
            //
			//// date4 gets 4/9/1996 5:55:00 PM.
			//System.DateTime date4 = date3.Subtract(diff1);
            //
			//// diff2 gets 55 days 4 hours and 20 minutes.
			//System.TimeSpan diff2 = date2 - date3;
            //
			//// date5 gets 4/9/1996 5:55:00 PM.
			//System.DateTime date5 = date1 - diff2;

namespace MobilePhoneDevice
{
    class Call
    {
        // Fields
        private DateTime callStart;
        private DateTime callEnd;
        private int dialedNumbers;
        private double duration;

        // Properties
        public DateTime CallStart
        {
            get { return this.callStart; }
        }

        public DateTime CallEnd
        {
            get { return this.callEnd; }
        }

        public double Duration
        {
            get
            {
                return CalcDuration( duration );
            }
        }

        public int DialedNumbers
        {
            get { return this.dialedNumbers; }
        }

        // Methods
        private double CalcDuration(double duration) // Calculate call duration
        {
            duration = this.callEnd.Subtract(this.callStart).TotalSeconds;
            return duration;
        }

        // Constructor
        public Call(DateTime callStart, DateTime callEnd, int dialedNumbers)
        {
            this.callStart = callStart;
            this.callEnd = callEnd;
            this.dialedNumbers = dialedNumbers;
            this.duration = 0;
        }
    }
}
