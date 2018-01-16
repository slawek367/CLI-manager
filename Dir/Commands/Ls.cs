using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dir.Commands
{
    static class Ls
    {
        public static void GetParameters(string[] args)
        {
            if (args.Length == 0)
            {
                ListFiles();
            }
            else if (args[0] == "..")
            {
                try
                {
                    System.IO.Directory.SetCurrentDirectory(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("Can't do this!");
                }
            }
        }

        public static void ListFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

            var files = dir.GetFiles();
            var directories = dir.GetDirectories();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var item in directories)
            {
                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }
    }
}
