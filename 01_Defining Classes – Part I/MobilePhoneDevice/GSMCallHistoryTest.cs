using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    /// <summary>
    /// Може би нямаше да е зле да имаме една лекция за Unit tests, вместо да се занимаваме с подобни простотии
    /// 
    /// Class GSMCallHistoryTest to test the call history functionality of the GSM class.
    /// Create an instance of the GSM class.
    /// Add few calls.
    /// Display the information about the calls.
    /// Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
    /// Remove the longest call from the history and calculate the total price again.
    /// Finally clear the call history and print it.
    /// </summary>
    class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            GSM testSubject = new GSM("8210", "Nokia");
            testSubject.AddCall(new Call(new DateTime(1996, 6, 3, 22, 15, 0), new DateTime(1996, 7, 6, 13, 2, 0), 0885888881));
            testSubject.AddCall(new Call(new DateTime(1996, 6, 3, 22, 15, 0), new DateTime(1996, 8, 6, 13, 2, 0), 0885888882));
            testSubject.AddCall(new Call(new DateTime(1996, 6, 3, 22, 15, 0), new DateTime(1996, 9, 6, 13, 2, 0), 0885888883));

            //Display the information about the calls
            Console.WriteLine("Information about the calls:");
            PrintCallsInfo(testSubject);
            Console.WriteLine();

            // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.Write("Total price of calls for 0.37 per minute: ");
            Console.WriteLine(testSubject.CalcCallsPrice(0.37));
            Console.WriteLine();

            //Remove the longest call from the history and calculate the total price again.
            double currentCall = 0;
            double longestCall = 0;
            int longestCallIndex = 0;

            //finds index of longest call
            for (int i = 0; i < testSubject.CallHistory.Count; i++)
            {
                currentCall = testSubject.CallHistory[i].Duration;
                if (currentCall > longestCall)
                {
                    longestCall = currentCall;
                    longestCallIndex = i;
                }
            }
            // Deletes Longest call
            testSubject.DeleteCall(longestCallIndex);

            //Prints information about the calls after longest is removed
            Console.WriteLine("Information about the calls after longest is removed:");
            PrintCallsInfo(testSubject);
            Console.WriteLine();

            // Calculate the total price again
            Console.Write("Total price again after longest is removed: ");
            Console.WriteLine(testSubject.CalcCallsPrice(0.37));
            Console.WriteLine();

            // Clear call history
            testSubject.ClearHistory();

            //Prints information about the calls after history is cleared
            Console.WriteLine("Calls after history is cleared");
            PrintCallsInfo(testSubject);
            Console.WriteLine();
        }

        // Help method that prints calls information
        public static void PrintCallsInfo(GSM test)
        {
            if (test.CallHistory.Count > 0)
            {
                for (int i = 0; i < test.CallHistory.Count; i++)
                {
                    Console.WriteLine("Call duration: {0} seconds, number: {1}", test.CallHistory[i].Duration, test.CallHistory[i].DialedNumbers);
                }
            }
            else
            {
                Console.WriteLine("Calls history is empty!");
            }

        }
    }
}
