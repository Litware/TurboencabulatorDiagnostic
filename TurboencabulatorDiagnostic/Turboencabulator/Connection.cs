using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.InteropServices;

namespace TurboencabulatorDiagnostic
{ 
    class Connection
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsConnectedToTurboencabulator()
        {
            int Desc;

            return InternetGetConnectedState(out Desc, 0);
        }
    }
}
