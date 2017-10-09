using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboencabulatorDiagnostic
{
    class Songs
    {
        public static void GetSongs(string SongName)
        {
            string[] allfiles = Directory.GetFiles(".\\", SongName + ".txt", System.IO.SearchOption.AllDirectories);

            if (allfiles != null)
            {
                var lines = File.ReadLines(allfiles[0]);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
