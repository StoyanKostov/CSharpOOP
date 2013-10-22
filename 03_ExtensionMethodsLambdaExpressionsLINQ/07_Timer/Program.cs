/// Using delegates write a class Timer that has can execute certain method at each t seconds.
/// Погледнах решенята в форума, но погледна и един туториал на Майкрософт и реших да следвам тяхната логика за имплементирането да делегат в клас
/// на линка по-долу
/// http://msdn.microsoft.com/en-us/library/aa288459%28v=vs.71%29.aspx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _07_Timer
{
    // Declare a delegate type for processing a book:
    public delegate void ProcessMethod(string param);

    public class Timer
    {
        // Propartise
        public uint Secondes { get; set; }

        // Constructor
        public Timer(uint secondes)
        {
            this.Secondes = secondes;
        }

        // Call a passed-in delegate 
        public void Run(ProcessMethod Process)
        {
            while ( Secondes > 0 )
            {
                Process("Method executed");
                System.Threading.Thread.Sleep(1000);
                Secondes--;
            }
        }

        class Program
        {
            static void PrintOK(string param)
            {
                Console.WriteLine(param);
            }

            static void Main()
            {
                // Delegate will be called every second for 5 times
                Timer myTmr = new Timer(5);
                myTmr.Run(new ProcessMethod(PrintOK));
            }
        }
    }
}