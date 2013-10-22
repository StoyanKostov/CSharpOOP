using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    /// <summary>
    /// class GSMTest to test the GSM class:
    /// Create an array of few instances of the GSM class.
    /// Display the information about the GSMs in the array.
    /// Display the information about the static property IPhone4S.
    /// </summary>
    class GSMTest
    {
        static void Main(string[] args)
        {
            // Creates array to contain the intances
            List<GSM> mobiles = new List<GSM>();

            // Fills container with test phones
            mobiles.Add( new GSM( "8210", "Nokia" ) );
            mobiles.Add( new GSM( "8210", "Nokia", 12, "Stoyan", new Battery( "Original", 12, 10, BatteryType.LiIon ), new Display( "Samsung", 6, 256 ) ) );
            mobiles.Add( new GSM( "8210", "Nokia", 12, null, new Battery( null, 12, 10, BatteryType.LiIon ) ) );
            mobiles.Add( new GSM( "8210", "Nokia", 12, "Stoyan", null, new Display( "Samsung", 6, 256 ) ) );
            mobiles.Add( new GSM( "8210", "Nokia", 12, "Stoyan", new Battery( null, 12, 10, BatteryType.LiIon ), new Display( "Samsung" ) ) );
            mobiles.Add( new GSM( "8210", "Nokia", 12, "Stoyan", new Battery( null, 12, 10, BatteryType.LiIon ), new Display( "Samsung", 6 ) ) );

            // Tests static method of class GSM
            GSM.IPhone4S();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Tests the GSM class instances
            foreach (var mobile in mobiles)
            {
                Console.WriteLine(mobile);
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Tests Call History
            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}
