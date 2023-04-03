using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMLShopParser.Services
{
    public enum CliArgs
    {
        Save,
        Print,
        Default
    }

    public class ArgsService
    {      
        public static CliArgs ParseArgs(string[] args)
        {
            bool isValid = ValidateArgs(args);

            if (!isValid)
            {
                return CliArgs.Default;
            }

            switch (args[0].ToUpper())
            {
                case "SAVE":
                    return CliArgs.Save;
                case "PRINT":
                    return CliArgs.Print;
                default:
                    Console.WriteLine("Please enter a valid key such as \"-- save <url>\" or \"-- print <shopId>\"");
                    Console.WriteLine("Press any key to close the app");
                    Console.ReadKey();
                    return CliArgs.Default;
            }
        }

        private static bool ValidateArgs(string[] args)
        {
            if (args.Length == 0 || args.Length > 2)
            {
                Console.WriteLine("Incorrect argument input. Please enter a valid key such as \"-- save <url>\" or \"-- print <shopName>\"");
                Console.WriteLine("Press any key to close the app");
                Console.ReadKey();

                return false;
            }
            return true;
        }
    }
}
