using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    class Program
    {
        static Engine GetEngineInstance()
        {
            return new ExtendedEngine();
        }

        static void Main(string[] args)
        {
            Engine engine = GetEngineInstance();

            //engine.ExecuteCommand("create giant cecameca (10,10)");
            //engine.ExecuteCommand("create stone 6 (10,10)");
            //engine.ExecuteCommand("cecameca gather");
            //engine.ExecuteCommand("cecameca go (2,2)");
            //engine.ExecuteCommand("cecameca attack");

            string command = Console.ReadLine();
            while (command != "end")
            {
                engine.ExecuteCommand(command);
                command = Console.ReadLine();
            }
        }
    }
}
