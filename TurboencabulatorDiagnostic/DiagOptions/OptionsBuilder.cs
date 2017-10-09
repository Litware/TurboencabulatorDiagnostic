using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboencabulatorDiagnostic.DiagOptions
{
    class OptionsBuilder
    {
        public static DiagOption BuildOptionsMenu()
        {
            DiagOption root = new DiagOption("", null);

            DiagOption transmissionSystems = new DiagOption("Transmission Systems", null, root);
            DiagOption turboEncabulator = new DiagOption("Turbo Encabulator", () => Turboencabulator.IsConnected(), transmissionSystems);
            DiagOption turboEncabulatorRunning = new DiagOption("Get running status", () => Turboencabulator.IsRunning(), turboEncabulator);
            DiagOption turboEncabulatorRunTest = new DiagOption("Run Test", () => Turboencabulator.RunTest(), turboEncabulator);

            DiagOption engine = new DiagOption("Engine Sounds", () => Console.WriteLine("Rumble Rumble Rumble..."), root);

            DiagOption hatSize = new DiagOption("Hat size", () => Hat.GetHatSize(), root);

            DiagOption songs = new DiagOption("Songs", null, root);
            DiagOption xmasSongs = new DiagOption("Christmas", null, songs);
            DiagOption OChristmasTree = new DiagOption("O Christmas Tree", () => Songs.GetSongs("OChristmasTree"), xmasSongs);
            DiagOption twelvedays = new DiagOption("12 Crazy Days Of Christmas", () => Songs.GetSongs("12CrazyDays"), xmasSongs);
            DiagOption twoteeth = new DiagOption("All I Want For Christmas Is My Two Front Teeth", () => Songs.GetSongs("twoteeth"), xmasSongs);
            DiagOption thanksSongs = new DiagOption("Thanksgiving", () => Console.WriteLine("There are no Thanksgiving songs :("), songs);

            DiagOption cigaretteLighter = new DiagOption("cigarette lighter", null, root);
            DiagOption cigaretteLighterOperation = new DiagOption("Operation", () => Console.WriteLine("Coming soon"), cigaretteLighter);
            DiagOption cigaretteLighterDiagnosis = new DiagOption("Diagnosis", () => Console.WriteLine("Coming soon"), cigaretteLighter);
            DiagOption cigaretteLighterRepair = new DiagOption("Repair", () => Console.WriteLine("Coming soon"), cigaretteLighter);

            return root;
        }
    }
}
