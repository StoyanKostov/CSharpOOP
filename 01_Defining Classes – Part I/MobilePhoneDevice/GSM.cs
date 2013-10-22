using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class GSM
    {
        // Fields 0800 200 11    0800 20 400 
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        // Properties
        public string Model
        {
            get { return this.model ;}
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public double? Price
        {
            get { return this.price; }
            set 
            {
                if (this.price <= 0)
                {
                    throw new ArgumentException("Ivalid price input!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
        }

        // Methods
        public override string ToString() // Overwrite the toString method for current class
        {
            return string.Format("GSM model: {0}\nGSM manufacturer: {1}\nGSM price: {2}\nGSM owner: {3}\nBattery: {4}\nDisplay: {5}",
                                  this.Model, this.Manufacturer, this.Price, this.Owner, this.Battery, this.Display);
        }

        public static void IPhone4S() // Adds static method that provides some usefull information
        {
            Console.WriteLine("Some information about iPhone 4S");
        }

        public void AddCall(Call makeCall) // Adds a call in the history
        {
            callHistory.Add(makeCall);
        }

        public void DeleteCall(int callIndex) // Deletes given call by its index
        {
            callHistory.RemoveAt(callIndex);
        }

        public void ClearHistory() // Clears call history
        {
            callHistory.Clear();
        }

        public double CalcCallsPrice(double price) // Calculate Total Price of Calls (per minute)
        {
            double totalPrice = 0;

            foreach (Call item in this.CallHistory)
            {
                totalPrice += (double)item.Duration / 60;
            }
            return totalPrice;
        }

        // Constructor
        public GSM(string model, string manufacturer, double? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Call>();
        }

    }
}
