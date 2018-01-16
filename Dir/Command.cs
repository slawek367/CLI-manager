using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    static class Command
    {
        public static Dictionary<string, Action<string[]>> commandList =
            new Dictionary<string, Action<string[]>>()
            {
                { "help", HelpFunc },
                { "cd", Cd },
                { "ls", Ls },
            };

        public static void HelpFunc(string[] args)
        {
            Console.WriteLine("xD");
        }

        public static void Cd(string[] args)
        {
            Dir.Commands.Cd.GetParameters(args);
        }

        public static void Ls(string[] args)
        {
            Dir.Commands.Ls.GetParameters(args);
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
