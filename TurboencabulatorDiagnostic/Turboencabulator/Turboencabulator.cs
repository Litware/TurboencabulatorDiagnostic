using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboencabulatorDiagnostic
{
    public static class Turboencabulator
    {
        public static void IsConnected()
        {
           Console.WriteLine("Connnected to Turbo Encabulator: " + Connection.IsConnectedToTurboencabulator());
        }

        public static void IsRunning()
        {
            if (Connection.IsConnectedToTurboencabulator() && Status.IsRunning())
            {
                Console.WriteLine("Running: Yes, You better go catch it!");
            }
            else
            {
                Console.WriteLine("Running: Not even a little");
            }

            Console.WriteLine("Efficiency Percentage: " + Status.EfficiencyPercentage());

            if (Status.EfficiencyPercentage() > 99)
            {
                Console.WriteLine("WARNING: Turbo Encabulator appears to be lying.");
                Console.WriteLine("Do not trust test results");
            }
        }

        public static void RunTest()
        {
            Random rand = new Random();

            int pause = rand.Next(1, 5);

            for (int k = 0; k < pause; k++)
            {
                Console.WriteLine("Please wait, performing test...");
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Head code: " + rand.Next(10000, 20000));
            Console.WriteLine("wrench-in output of the capacity reactance flux muster: " + rand.Next(0, 20) + "rgs");
        }
    }
}
