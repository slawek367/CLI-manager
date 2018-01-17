using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    static class ConsoleManager
    {


        public static void Configure(string color)
        {

            switch (color)
            {
                case "blue": Console.BackgroundColor = ConsoleColor.Blue; break;
                case "black": Console.BackgroundColor = ConsoleColor.Black; break;
                case "yellow": Console.BackgroundColor = ConsoleColor.Yellow; break;
                case "cyan": Console.BackgroundColor = ConsoleColor.Cyan; break;
                default: break;
            }
            Console.Clear();
        }

        public static void Start()
        {
            CommandLine cli = new CommandLine();
            while (true)
            {
                cli.GetInput();
            }
        }
    }
}
