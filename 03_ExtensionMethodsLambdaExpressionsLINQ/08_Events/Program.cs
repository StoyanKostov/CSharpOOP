﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Events
{
    class Program
    {
        static void Main()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;

            //call timer_Tick every second
            timer.Start();

            while (true)
            {
                Console.Write("Enter timer interval [-1 to stop]: ");
                int newInterval = int.Parse(Console.ReadLine());
                if (newInterval == -1)
                {
                    timer.Stop();
                    break;
                }
                else
                {
                    timer.Interval = newInterval;
                }
            }
        }

        static void timer_Tick(object sender)
        {
            Console.Beep();
        }
    }
}
