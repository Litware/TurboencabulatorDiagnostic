using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboencabulatorDiagnostic
{
    class Status
    {
        public static bool IsRunning()
        {
            Random rand = new Random();

            return rand.Next(0, 1) == 0;
        }

        public static int EfficiencyPercentage()
        {
            Random rand = new Random();

            return rand.Next(0, 101);
        }
    }
}
