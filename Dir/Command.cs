using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    static class Command
    {
        private static Dictionary<string, Action<string[]>> commandList =
            new Dictionary<string, Action<string[]>>()
            {
                { "help", HelpFunc },
            };

        public static void HelpFunc(string[] args)
        {
            Console.WriteLine("xD");
        }

        public static bool Exists(string command)
        {
            if (commandList.ContainsKey(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
