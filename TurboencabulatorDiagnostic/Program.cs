using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TurboencabulatorDiagnostic.DiagOptions;

namespace TurboencabulatorDiagnostic
{
    class Program
    {
        static void Main(string[] args)
        {
            DiagOption root = OptionsBuilder.BuildOptionsMenu();

            Console.WriteLine(Strings.TitleText);

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.WriteLine(Strings.VersionText + version);
            Console.WriteLine("Back to navigate back, quit to quit.");

            Console.WriteLine("Please enter make/model of vehicle.");
            string makeModel = Console.ReadLine();

            bool continueDiag = true;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("==========");

                // run action of previous selection
                if (root.action != null)
                {
                    Console.WriteLine("==========");
                    root.action.Invoke();

                    Console.WriteLine("");
                    Console.WriteLine("==========");
                }

                // if current root has no children, go up a level
                if (root.children.Count == 0)
                    root = root.parent;

                // print current selection options
                foreach(DiagOption option in root.children)
                {
                    Console.WriteLine(option.text);
                }

                // read user choice and do it
                Console.WriteLine("");
                Console.Write("Select next actions: ");
                string result = Console.ReadLine();

                int optionSelected = root.children.FindIndex(x => x.text.Equals(result, StringComparison.CurrentCultureIgnoreCase));

                if(optionSelected != -1)
                {
                    root = root.children[optionSelected];
                }
                else if (result.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
                {
                    continueDiag = false;
                }
                else if (result.Equals("back", StringComparison.CurrentCultureIgnoreCase) && root.parent != null)
                {
                    root = root.parent;
                }
            }
            while (continueDiag == true);
        }
    }
}
