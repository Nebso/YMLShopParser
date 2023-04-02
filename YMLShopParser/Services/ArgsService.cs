using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Providers;
using YMLShopParser.Repos;

namespace YMLShopParser.Services
{
    public class ArgsService
    {
        private readonly string[] _args;
    
        public ArgsService(string[] args)
        {
            _args = args;
        }

        public void ParseArgs()
        {
            ValidateArgs(_args);

            switch (_args[0].ToUpper())
            {
                case "SAVE":
                    _shopService.Save(_args[1]);
                    break;
                case "PRINT":
                    _shopService.Print(_args[1]);
                    break;
                default:
                    Console.WriteLine("Please enter a valid key such as \"-- save <url>\" or \"-- print <shopId>\"");
                    Console.WriteLine("Press any key to close the app");
                    Console.ReadKey();
                    break;
            }
        }

        private static void ValidateArgs(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments provided. Please enter a valid key such as \"-- save <url>\" or \"-- print <shopId>\"");
                Console.WriteLine("Press any key to close the app");
                Console.ReadKey();

                return;
            }
        }
    }
}
